using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SuperSimpleStocks
{
    public partial class Main : Form
    {
        /// <summary>
        /// The stock list
        /// </summary>
        private readonly List<Stock> stockList = new List<Stock>();

        /// <summary>
        /// The trade list
        /// </summary>
        private readonly List<Trade> tradeList = new List<Trade>();

        /// <summary>
        /// The duration to calculate the stock price over.
        /// </summary>
        private readonly int StockPriceDurationSeconds = 900;

        public Main()
        {
            InitializeComponent();

            // Bind the type of trade selector to the trade type.
            tradeTypeSelect.DataSource = Enum.GetNames(typeof(Trade.TradeType));
        }

        /// <summary>
        /// Handles the Click event of the createStocksBtn control.
        /// Created the 5 stocks from the hard coded values.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void createStocksBtn_Click(object sender, EventArgs e)
        {
            WriteLn("Creating stocks:");

            // Enpty the stock list.
            stockList.Clear();

            // Enpty the trades list.
            tradeList.Clear();

            stockList.Add(new Stock("TEA", Stock.StockType.Common, 0, 0, 100));
            WriteLn(string.Format("  Created stock {0}", stockList.Last().Symbol));

            stockList.Add(new Stock("POP", Stock.StockType.Common, 8, 0, 100));
            WriteLn(string.Format("  Created stock {0}", stockList.Last().Symbol));

            stockList.Add(new Stock("ALE", Stock.StockType.Common, 23, 0, 60));
            WriteLn(string.Format("  Created stock {0}", stockList.Last().Symbol));

            stockList.Add(new Stock("GIN", Stock.StockType.Preferred, 8, 2, 100));
            WriteLn(string.Format("  Created stock {0}", stockList.Last().Symbol));

            stockList.Add(new Stock("JOE", Stock.StockType.Common, 13, 0, 250));
            WriteLn(string.Format("  Created stock {0}", stockList.Last().Symbol));

            WriteLn("Done");

            // Bind the stock combo box to the stock list.
            stocksSelect.ValueMember = "Symbol";
            stocksSelect.DisplayMember = "Symbol";
            stocksSelect.DataSource = stockList;
        }

        /// <summary>
        /// Handles the Click event of the dividendYieldButton control.
        /// Looks up the selected stock and get the entered ticker price to calculate the dividend yield.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dividendYieldButton_Click(object sender, EventArgs e)
        {
            // Get the selected stock.
            Stock tempStock = GetSelectedStock();

            // Get the entered ticker price.
            double tickerPrice = GetTickerPrice();

            // Check the a stock was selected.
            if (tempStock == null)
            {
                return;
            }

            // Check the ticker price is valid.
            if (Double.IsNaN(tickerPrice))
            {
                return;
            }

            // Get the dividend yield for the stock and ticker price.
            double dividendYield = tempStock.DividendYield(tickerPrice);

            // Output the dividend yield.
            WriteLn(string.Format("Dividend Yeild for {0} is {1}",
                tempStock.Symbol,
                dividendYield.ToString("N2")));
        }

        /// <summary>
        /// Handles the Click event of the peRatioBtn control.
        /// Looks up the selected stock and get the entered ticker price to calculate the PE ratio.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void peRatioBtn_Click(object sender, EventArgs e)
        {
            // Get the selected stock.
            Stock tempStock = GetSelectedStock();

            // Get the entered ticker price.
            double tickerPrice = GetTickerPrice();

            // Check the a stock was selected.
            if (tempStock == null)
            {
                return;
            }

            // Check the ticker price is valid.
            if (Double.IsNaN(tickerPrice))
            {
                return;
            }

            // Get the PE Ratio for the stock and ticker price.
            double peRatio = tempStock.PeRatio(tickerPrice);

            // Output the PE ratio.
            WriteLn(string.Format("Dividend Yeild for {0} is {1}",
                tempStock.Symbol,
                peRatio.ToString("N2")));
        }

        /// <summary>
        /// Handles the Click event of the recordTradeBtn control.
        /// Looks up the UI values and creates a trade with them.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void recordTradeBtn_Click(object sender, EventArgs e)
        {
            // Get the selected stock.
            Stock tempStock = GetSelectedStock();

            // Get the entered ticker price.
            double tickerPrice = GetTickerPrice();

            // Get the entered trade quantity.
            int tradeQuantity = GetTradeQuantity();

            // Get the selected trade type.
            Trade.TradeType tradeType = GetTradeType();

            // Check the a stock was selected.
            if (tempStock == null)
            {
                return;
            }

            // Check the ticker price is valid.
            if (Double.IsNaN(tickerPrice))
            {
                return;
            }

            // Check the trade quantity is valid.
            if (tradeQuantity == 0)
            {
                return;
            }

            // Create a new trade.
            tradeList.Add(new Trade(tempStock, DateTime.Now, tradeQuantity, tradeType, tickerPrice));
            WriteLn(string.Format("Trade recorded at {0:yyyy-MM-dd hh:mm:ss}", tradeList.Last().TimeStamp));
        }

        /// <summary>
        /// Handles the Click event of the stockPriceBtn control.
        /// Calculates the stock price for the selected stock over a given time range.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void stockPriceBtn_Click(object sender, EventArgs e)
        {
            // Get the selected stock.
            Stock tempStock = GetSelectedStock();

            // Check the a stock was selected.
            if (tempStock == null)
            {
                return;
            }

            // Find all the trades for the selected stock over the given time range.
            List<Trade> stockTrades = tradeList.FindAll(t => (t.Stock.Symbol == tempStock.Symbol) && (t.TimeStamp > DateTime.Now.AddSeconds(-1*StockPriceDurationSeconds)));

            if (stockTrades.Count > 0)
            {
                // Got stocks, calculate the stock price.
                double stockPrice = CalculateStockPrice(stockTrades);

                WriteLn(string.Format("Stock price for the {0} trades in the last {1} minutes is {2}",
                    stockTrades.Count.ToString(),
                    StockPriceDurationSeconds/60,
                    stockPrice.ToString("N2")));
            }
            else
            {
                // No trades found for this stock, give a message.
                WriteLn(string.Format("No trades found for {0} in the last {1} minutes",
                    tempStock.Symbol,
                    StockPriceDurationSeconds / 60));
            }
        }

        /// <summary>
        /// Handles the Click event of the gbceAllStocksBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void gbceAllStocksBtn_Click(object sender, EventArgs e)
        {
            // Check there are stocks in the list.
            if (stockList.Count == 0)
            {
                WriteLn("There are no stocks to calculate the GBCE for.");
                return;
            }

            // Check there are trades in the list.
            if (tradeList.Count == 0)
            {
                WriteLn("There are no trades to calculate the GBCE over.");
                return;
            }

            // Initialise the aggregate.
            double stockPriceAggregate = 1;

            // Iterate through the stocks building the stock price aggregate.
            foreach (Stock tempStock in stockList)
            {
                // Find all trades for the surrent stock.
                List<Trade> stockTrades = tradeList.FindAll(t => (t.Stock.Symbol == tempStock.Symbol));

                if (stockTrades.Count > 0)
                {
                    // Got trades, get the stock price.
                    double stockPrice = CalculateStockPrice(stockTrades);

                    // Add the stock price to the aggregate.
                    stockPriceAggregate *= stockPrice;
                }
            }

            // Calculate the GBCE.
            double gbce = Math.Pow(stockPriceAggregate, 1.0/stockList.Count);

            WriteLn(string.Format("GBCE for all stocks is {0}", gbce.ToString("N2")));
        }

        /// <summary>
        /// Calculates the stock price.
        /// </summary>
        /// <param name="stockTrades">The stock trades.</param>
        /// <returns>
        /// The stock price for the given trades.
        /// </returns>
        private double CalculateStockPrice(List<Trade> stockTrades)
        {
            return stockTrades.Sum(t => (t.Price * t.Quantity)) / stockTrades.Sum(t => (t.Quantity));
        }

        /// <summary>
        /// Gets the selected stock.
        /// </summary>
        /// <returns>
        /// Returns the selected stock.
        /// </returns>
        private Stock GetSelectedStock()
        {
            // Get the selected stock symbol and look it up in the stock list.
            Stock tempStock = stockList.Find(s => s.Symbol == (string) stocksSelect.SelectedValue);

            if (tempStock != null)
            {
                // Stock was found in the list, return it.
                return tempStock;
            }

            // Stock was not found in the list, flag the error and return null.
            WriteLn("PLEASE SELECT A STOCK");
            return null;
        }

        /// <summary>
        /// Gets the ticker price.
        /// </summary>
        /// <returns>
        /// The entered ticker price.
        /// </returns>
        private double GetTickerPrice()
        {
            // Get the entered value.
            string tickerPriceStr = tickerPriceTxt.Text;

            double tickerPriceDbl;

            // Check it is a number.
            if (Double.TryParse(tickerPriceStr, out tickerPriceDbl))
            {
                // Value is valid, return it.
                return tickerPriceDbl;
            }

            // Entered value is not valid, flag the error and return not a number. 
            WriteLn("TICKER PRICE MUST BE A NUMBER");
            return Double.NaN;
        }

        /// <summary>
        /// Gets the selected trade quantity.
        /// </summary>
        /// <returns>
        /// The entered trade quantity.
        /// </returns>
        private int GetTradeQuantity()
        {
            // Get the entered value.
            string tradeQuantityStr = tradeQuantityTxt.Text;

            Int16 tradeQuantityInt;

            // Check it is a number.
            if (Int16.TryParse(tradeQuantityStr, out tradeQuantityInt))
            {
                // It is a number, check for zero.
                if (tradeQuantityInt == 0)
                {
                    // Entered value is zero, flag the error and return zero.
                    WriteLn("TRADE QUANTITY MUST BE NON ZERO");
                    return 0;
                }

                // Entered value is OK, return it.
                return tradeQuantityInt;
            }

            // Entered value is not valid, flag the error and return zero. 
            WriteLn("TRADE QUANTITY MUST BE A NUMBER");
            return 0;
        }

        /// <summary>
        /// Gets the selected trade type from the UI.
        /// </summary>
        /// <returns>
        /// The trade type.
        /// </returns>
        private Trade.TradeType GetTradeType()
        {
            // Get the selected value.
            string tradeTypeStr = tradeTypeSelect.Text;

            // Convert the selected value to the trade type. The selector is bound to this type so there must be a match.
            Trade.TradeType tradeType = (Trade.TradeType)Enum.Parse(typeof(Trade.TradeType), tradeTypeStr);

            // Return the selected value.
            return tradeType;
        }

        /// <summary>
        /// Writes a line to the top of output text box.
        /// </summary>
        /// <param name="msg">The message.</param>
        private void WriteLn(string msg)
        {
            outputTxt.Text = msg + Environment.NewLine + outputTxt.Text;
        }
    }
}

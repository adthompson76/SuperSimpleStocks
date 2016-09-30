namespace SuperSimpleStocks
{
    class Stock
    {
        /// <summary>
        /// Defined the 2 available stock types.
        /// </summary>
        public enum StockType
        {
            Common,
            Preferred
        }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public StockType Type { get; set; }

        /// <summary>
        /// Gets or sets the last dividend.
        /// </summary>
        /// <value>
        /// The last dividend.
        /// </value>
        public int LastDividend { get; set; }

        /// <summary>
        /// Gets or sets the fixed dividend.
        /// </summary>
        /// <value>
        /// The fixed dividend.
        /// </value>
        public int FixedDividend { get; set; }

        /// <summary>
        /// Gets or sets the par value.
        /// </summary>
        /// <value>
        /// The par value.
        /// </value>
        public int ParValue { get; set; }

        /// <summary>
        /// Constructor for the Stock object.
        /// </summary>
        /// <param name="symbol">The text symbol for the stock.</param>
        /// <param name="type">The type of the stock.</param>
        /// <param name="lastDividend">The last dividend for the stock.</param>
        /// <param name="fixedDividend">The fixed dividend for the stock.</param>
        /// <param name="parValue">The par value for the stock.</param>
        public Stock(string symbol, StockType type, int lastDividend, int fixedDividend, int parValue)
        {
            Symbol = symbol;
            Type = type;
            LastDividend = lastDividend;
            FixedDividend = fixedDividend;
            ParValue = parValue;
        }

        /// <summary>
        /// Calculated the dividend yield for the stock
        /// </summary>
        /// <param name="tickerPrice">The ticker price.</param>
        /// <returns>
        /// The dividend yield depending on the stock type.
        /// </returns>
        public double DividendYield(double tickerPrice)
        {
            switch (Type)
            {
                case StockType.Common:
                    return LastDividend/tickerPrice;

                case StockType.Preferred:
                    return (FixedDividend*ParValue)/tickerPrice;

                default:
                    return double.NaN;
            }
        }

        /// <summary>
        /// PE ratio for the stock.
        /// </summary>
        /// <param name="tickerPrice">The ticker price.</param>
        /// <returns>
        /// The PE ratio.
        /// </returns>
        public double PeRatio(double tickerPrice)
        {
            double dividendYield = DividendYield(tickerPrice);

            if (!double.IsNaN(dividendYield))
            {
                return tickerPrice/dividendYield;
            }

            return double.NaN;
        }
    }
}

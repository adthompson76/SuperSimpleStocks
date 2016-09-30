using System;

namespace SuperSimpleStocks
{
    class Trade
    {
        /// <summary>
        /// Defines the 2 available trade types.
        /// </summary>
        public enum TradeType
        {
            Buy,
            Sell
        }

        /// <summary>
        /// Gets or sets the stock.
        /// </summary>
        /// <value>
        /// The stock.
        /// </value>
        public Stock Stock { get; set; }

        /// <summary>
        /// Gets or sets the time stamp.
        /// </summary>
        /// <value>
        /// The time stamp.
        /// </value>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public TradeType Type { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trade"/> class.
        /// </summary>
        /// <param name="stock">The stock.</param>
        /// <param name="timeStamp">The time stamp.</param>
        /// <param name="quantity">The quantity.</param>
        /// <param name="type">The type.</param>
        /// <param name="price">The price.</param>
        public Trade(Stock stock, DateTime timeStamp, int quantity, TradeType type, double price)
        {
            Stock = stock;
            TimeStamp = timeStamp;
            Quantity = quantity;
            Type = type;
            Price = price;
        }
    }
}

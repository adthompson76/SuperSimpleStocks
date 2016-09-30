namespace SuperSimpleStocks
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createStocksBtn = new System.Windows.Forms.Button();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.stocksSelect = new System.Windows.Forms.ComboBox();
            this.dividendYieldButton = new System.Windows.Forms.Button();
            this.tickerPriceTxt = new System.Windows.Forms.TextBox();
            this.stockLbl = new System.Windows.Forms.Label();
            this.tickerPriceLbl = new System.Windows.Forms.Label();
            this.peRatioBtn = new System.Windows.Forms.Button();
            this.tradeQuantityTxt = new System.Windows.Forms.TextBox();
            this.tradeQuantityLbl = new System.Windows.Forms.Label();
            this.recordTradeBtn = new System.Windows.Forms.Button();
            this.tradeTypeSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockPriceBtn = new System.Windows.Forms.Button();
            this.gbceAllStocksBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createStocksBtn
            // 
            this.createStocksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createStocksBtn.Location = new System.Drawing.Point(30, 17);
            this.createStocksBtn.Name = "createStocksBtn";
            this.createStocksBtn.Size = new System.Drawing.Size(153, 27);
            this.createStocksBtn.TabIndex = 0;
            this.createStocksBtn.Text = "Create Stocks";
            this.createStocksBtn.UseVisualStyleBackColor = true;
            this.createStocksBtn.Click += new System.EventHandler(this.createStocksBtn_Click);
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(29, 201);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTxt.Size = new System.Drawing.Size(643, 232);
            this.outputTxt.TabIndex = 1;
            // 
            // stocksSelect
            // 
            this.stocksSelect.DropDownHeight = 120;
            this.stocksSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocksSelect.FormattingEnabled = true;
            this.stocksSelect.IntegralHeight = false;
            this.stocksSelect.ItemHeight = 16;
            this.stocksSelect.Location = new System.Drawing.Point(75, 60);
            this.stocksSelect.Name = "stocksSelect";
            this.stocksSelect.Size = new System.Drawing.Size(94, 24);
            this.stocksSelect.TabIndex = 2;
            // 
            // dividendYieldButton
            // 
            this.dividendYieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividendYieldButton.Location = new System.Drawing.Point(101, 104);
            this.dividendYieldButton.Name = "dividendYieldButton";
            this.dividendYieldButton.Size = new System.Drawing.Size(104, 29);
            this.dividendYieldButton.TabIndex = 3;
            this.dividendYieldButton.Text = "Dividend Yeild";
            this.dividendYieldButton.UseVisualStyleBackColor = true;
            this.dividendYieldButton.Click += new System.EventHandler(this.dividendYieldButton_Click);
            // 
            // tickerPriceTxt
            // 
            this.tickerPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickerPriceTxt.Location = new System.Drawing.Point(280, 60);
            this.tickerPriceTxt.Name = "tickerPriceTxt";
            this.tickerPriceTxt.Size = new System.Drawing.Size(49, 22);
            this.tickerPriceTxt.TabIndex = 4;
            this.tickerPriceTxt.Text = "1";
            this.tickerPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.Location = new System.Drawing.Point(27, 63);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(42, 16);
            this.stockLbl.TabIndex = 5;
            this.stockLbl.Text = "Stock";
            // 
            // tickerPriceLbl
            // 
            this.tickerPriceLbl.AutoSize = true;
            this.tickerPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickerPriceLbl.Location = new System.Drawing.Point(194, 63);
            this.tickerPriceLbl.Name = "tickerPriceLbl";
            this.tickerPriceLbl.Size = new System.Drawing.Size(80, 16);
            this.tickerPriceLbl.TabIndex = 6;
            this.tickerPriceLbl.Text = "Ticker Price";
            // 
            // peRatioBtn
            // 
            this.peRatioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peRatioBtn.Location = new System.Drawing.Point(280, 104);
            this.peRatioBtn.Name = "peRatioBtn";
            this.peRatioBtn.Size = new System.Drawing.Size(104, 29);
            this.peRatioBtn.TabIndex = 7;
            this.peRatioBtn.Text = "P/E Ratio";
            this.peRatioBtn.UseVisualStyleBackColor = true;
            this.peRatioBtn.Click += new System.EventHandler(this.peRatioBtn_Click);
            // 
            // tradeQuantityTxt
            // 
            this.tradeQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeQuantityTxt.Location = new System.Drawing.Point(449, 60);
            this.tradeQuantityTxt.Name = "tradeQuantityTxt";
            this.tradeQuantityTxt.Size = new System.Drawing.Size(49, 22);
            this.tradeQuantityTxt.TabIndex = 8;
            this.tradeQuantityTxt.Text = "1";
            this.tradeQuantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tradeQuantityLbl
            // 
            this.tradeQuantityLbl.AutoSize = true;
            this.tradeQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeQuantityLbl.Location = new System.Drawing.Point(347, 63);
            this.tradeQuantityLbl.Name = "tradeQuantityLbl";
            this.tradeQuantityLbl.Size = new System.Drawing.Size(96, 16);
            this.tradeQuantityLbl.TabIndex = 9;
            this.tradeQuantityLbl.Text = "Trade Quantity";
            // 
            // recordTradeBtn
            // 
            this.recordTradeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordTradeBtn.Location = new System.Drawing.Point(459, 104);
            this.recordTradeBtn.Name = "recordTradeBtn";
            this.recordTradeBtn.Size = new System.Drawing.Size(104, 29);
            this.recordTradeBtn.TabIndex = 10;
            this.recordTradeBtn.Text = "Record Trade";
            this.recordTradeBtn.UseVisualStyleBackColor = true;
            this.recordTradeBtn.Click += new System.EventHandler(this.recordTradeBtn_Click);
            // 
            // tradeTypeSelect
            // 
            this.tradeTypeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeTypeSelect.FormattingEnabled = true;
            this.tradeTypeSelect.Location = new System.Drawing.Point(592, 60);
            this.tradeTypeSelect.Name = "tradeTypeSelect";
            this.tradeTypeSelect.Size = new System.Drawing.Size(96, 24);
            this.tradeTypeSelect.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Trade Type";
            // 
            // stockPriceBtn
            // 
            this.stockPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockPriceBtn.Location = new System.Drawing.Point(101, 155);
            this.stockPriceBtn.Name = "stockPriceBtn";
            this.stockPriceBtn.Size = new System.Drawing.Size(209, 29);
            this.stockPriceBtn.TabIndex = 13;
            this.stockPriceBtn.Text = "Stock Price - Last 15 Minutes";
            this.stockPriceBtn.UseVisualStyleBackColor = true;
            this.stockPriceBtn.Click += new System.EventHandler(this.stockPriceBtn_Click);
            // 
            // gbceAllStocksBtn
            // 
            this.gbceAllStocksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbceAllStocksBtn.Location = new System.Drawing.Point(350, 155);
            this.gbceAllStocksBtn.Name = "gbceAllStocksBtn";
            this.gbceAllStocksBtn.Size = new System.Drawing.Size(213, 29);
            this.gbceAllStocksBtn.TabIndex = 14;
            this.gbceAllStocksBtn.Text = "Calculate GBCE All Stocks";
            this.gbceAllStocksBtn.UseVisualStyleBackColor = true;
            this.gbceAllStocksBtn.Click += new System.EventHandler(this.gbceAllStocksBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 456);
            this.Controls.Add(this.gbceAllStocksBtn);
            this.Controls.Add(this.stockPriceBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tradeTypeSelect);
            this.Controls.Add(this.recordTradeBtn);
            this.Controls.Add(this.tradeQuantityLbl);
            this.Controls.Add(this.tradeQuantityTxt);
            this.Controls.Add(this.peRatioBtn);
            this.Controls.Add(this.tickerPriceLbl);
            this.Controls.Add(this.stockLbl);
            this.Controls.Add(this.tickerPriceTxt);
            this.Controls.Add(this.dividendYieldButton);
            this.Controls.Add(this.stocksSelect);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.createStocksBtn);
            this.Name = "Main";
            this.Text = "Super Simple Stocks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createStocksBtn;
        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.ComboBox stocksSelect;
        private System.Windows.Forms.Button dividendYieldButton;
        private System.Windows.Forms.TextBox tickerPriceTxt;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.Label tickerPriceLbl;
        private System.Windows.Forms.Button peRatioBtn;
        private System.Windows.Forms.TextBox tradeQuantityTxt;
        private System.Windows.Forms.Label tradeQuantityLbl;
        private System.Windows.Forms.Button recordTradeBtn;
        private System.Windows.Forms.ComboBox tradeTypeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stockPriceBtn;
        private System.Windows.Forms.Button gbceAllStocksBtn;
    }
}


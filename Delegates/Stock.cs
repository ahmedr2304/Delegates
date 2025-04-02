using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * This link of the channel 
 * https://www.youtube.com/watch?v=F3ryldPGQoM
 * Events in C#
 */


namespace Delegates
{
    /// <summary>
    /// this delegate for handling the change price of the stock
    /// </summary>
    /// <param name="stock"></param>
    /// <param name="oldPrice"></param>
    public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);

    /// This is a Publisher 
    public class Stock
    {

        private string _name;
        private decimal _price;

        public event StockPriceChangeHandler onPriceChanged;
        public string Name => this._name;
        public decimal Price { get => this._price; set => this._price = value; }

        //Constructor 
        public Stock(string name) => this._name = name;
        public void ChangeStockPriceBy(decimal percentage)
        {
            decimal oldPrice = this._price;
            this._price += Math.Round(this._price * percentage, 2);
            
            if (onPriceChanged != null) // make sure there is subscriber
            {
                onPriceChanged(this, oldPrice); // firing the event 
            }


        }

      
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
  delegate void ChangepriceHandler(decimal oldprice, decimal newprice);
   public class Stock
    {
        string symbole;
        decimal price;

        public Stock(string symbole) => this.symbole = symbole;
        event ChangepriceHandler ChangePrice;

        public decimal Price
        {
            get => price;
            set
            {
                if (price == value) return;
                decimal OldVal = price;
                price = value;
                if (ChangePrice != null)
                    ChangePrice(OldVal, price);
            }
        }


    }
}

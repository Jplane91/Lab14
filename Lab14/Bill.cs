using System;
namespace Lab14
{
     public class Bill
    {
        public double Subtotal { get; set;}
        public double TaxRate { get; set; }

        public Bill()
        {

        }

        public Bill(double subTotal, double taxRate)
        {
            Subtotal = subTotal;
            TaxRate = taxRate;
        }

        public virtual double CalcTotal()
        {
            double total = Subtotal * (1 + TaxRate);
            return total;
        }
      
    }
}

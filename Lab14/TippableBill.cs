using System;
namespace Lab14
{
    public class TippableBill : Bill
    {
      public double Tip { get; set; }

        public TippableBill()
        {

        }

        public TippableBill(double subtotal, double taxrate, double tip) : base(subtotal, taxrate)
        {
            Subtotal = subtotal;
            Tip = tip;
            TaxRate = taxrate;
        }

        public override double CalcTotal()
        {

            double total = Subtotal *(1+ TaxRate )+ Tip;
            return total;
        }

    }
}

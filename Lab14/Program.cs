using System;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill(15.80, 0.06);
            TippableBill tippableBill = new TippableBill(8.50, 0.06, 2.00);

            Pay(bill);
            Pay(tippableBill);
        }

        public static void Pay(Bill bill)
        {
            double total = bill.CalcTotal();
            Console.WriteLine(total);
        }
    }
}

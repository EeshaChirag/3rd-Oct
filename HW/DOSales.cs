using System;


namespace HW
{
    class Sales
    {
        int salesno, productno, price, qty,totalamount;
        DateTime dateofsale;

        internal Sales(int salesno, int productno, int price, int qty, DateTime dateofsale)
        {
            this.salesno = salesno;
            this.productno = productno;
            this.price = price;
            this.qty = qty;
            this.dateofsale = dateofsale;
        }

        internal int TotalAmount()
        {
            return qty * price;
        }

        internal void Showdata()
        {
            totalamount = TotalAmount();
            Console.WriteLine("Sales Number:{0} || Product Number:{1} || Price:{2} || Quantity:{3} || Date of Sales:{4} || totalprice:{5}", salesno, productno, price, dateofsale, qty, totalamount);
        }

    }
    class DOSales
    {
        static void Main()
        {
            int salesno, productno, price, qty;
            DateTime dateofsale;

            Console.Write("Enter the sales number:");
            salesno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the product number:");
            productno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the product price:");
            price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the date of sales:");
            dateofsale = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter the product quantity:");
            qty = Convert.ToInt32(Console.ReadLine());

            Sales s = new Sales(salesno, productno,price, qty, dateofsale);
            s.Showdata();
            Console.ReadLine();
        }
    }
}

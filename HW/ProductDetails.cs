using System;


namespace HW
{
    class Product
    {
        int pid, price;
        string pname;
        internal static string shopname;

        internal Product(int pid, string pname, int price)
        {
            this.pid = pid;
            this.pname = pname;
            this.price = price;
        }
        
        internal void Display()
        {
            Console.WriteLine("ID:{0} || Name:{1} || Price:{2} ||Shop Name:{3}", pid, pname, price, shopname);
        }
    }
    class ProductDetails
    {
        static void Main()
        {
            Console.Write("Enter the Shop Name:");
            Product.shopname = Console.ReadLine();

            int size, pid, price;
            string pname;
            Console.Write("Enter the size of array:");
            size = Convert.ToInt32(Console.ReadLine());
            Product[] p = new Product[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the Product Id:");
                pid = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Product Name:");
                pname = Console.ReadLine();

                Console.Write("Enter the Product price:");
                price = Convert.ToInt32(Console.ReadLine());

                p[i] = new Product(pid, pname, price);
            }

            for (int i = 0; i < size; i++)
            {
                p[i].Display();
            }
            Console.ReadLine();


        }
    }
}

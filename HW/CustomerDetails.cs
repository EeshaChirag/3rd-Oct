using System;



namespace HW
{
    class Customer
    {
        int cid, age;
        string name, city,phone;

        internal Customer()
        {
            Console.WriteLine("Constructor with no argument");
        }
        internal Customer(int cid, string name, int age, string phone, string city)
        {
            this.cid = cid;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.city = city;
        }

        internal void DisplayCustomer()
        {
            Console.WriteLine("Customer Id:{0} || Customer Name:{1} || Age:{2} || Phone:{3}|| City:{4}",cid,name,age,phone,city);
        }
    }
    class CustomerDetails
    {
        static void Main()
        {
            int cid, age;
            string name, city,phone;

            Console.Write("Enter Customer Id:");
            cid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name:");
            name = Console.ReadLine();
            
            Console.Write("Enter Customer Age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Contact number:");
            phone = Console.ReadLine();

            Console.Write("Enter Customer City:");
            city = Console.ReadLine();

            Customer c = new Customer();

            Customer c1 = new Customer(cid, name, age, phone, city);
            c1.DisplayCustomer();

            Console.ReadLine();


        }
    }
}

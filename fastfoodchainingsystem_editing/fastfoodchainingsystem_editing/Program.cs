using System;
namespace fastfoodchainingsystem_editing
{
    class fastfood
    {
        public fastfood()
        {
            Console.WriteLine("fast food");
        }
        public void fastfoodtype()
        {
            Console.WriteLine("fastfoodtype:burger broast wings");
        }
    }
    class burger : fastfood
    {
        public int no_of_pattie, price;
        public burger()
        {
            Console.WriteLine("burger");
        }
        public void brand()
        {
            Console.WriteLine("brand:MC Donalds");
        }
        public void Price()
        {
            Console.WriteLine("Enter the price of burger");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine($"Price = {price}");
        }
    }
    class bigmac : burger
    {
        public bigmac()
        {
            Console.WriteLine("Big Mac burger");
        }
        public void making()
        {
            Console.WriteLine("Big Mac burger includes");
            Console.WriteLine($"No. of pattie = {base.no_of_pattie}");
            Console.WriteLine("Lattice and Sauce");
        }
    }
    class burger_brand : bigmac
    {
        public burger_brand()
        {
            Console.WriteLine("brand of burger: Hardees");
        }
    }
    class program
    {
        static void Main()
        {
            burger_brand bur = new burger_brand();
            bur.fastfoodtype();
            bur.no_of_pattie = 2;
            bur.brand();
            bur.making();
            bur.Price();
            Console.ReadKey();
        }
    }
}
        
    


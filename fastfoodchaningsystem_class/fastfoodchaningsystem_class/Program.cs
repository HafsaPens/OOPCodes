using System;
namespace fastfoodchaningsystem_class
{
    class fastfood
    {
        public fastfood()
        {
            Console.WriteLine("Fast food");
        }
        public void fastfoodtype()
        {
            Console.WriteLine("Fast food type:Burger,Broast,Wings");
        }
    }
    class burger : fastfood
    {
        public burger()
        {
            Console.WriteLine("Burger");
        }
        public void brand()
        {
            Console.WriteLine("Brand:Mc Donalds");
        }
        public void price()
        {
            Console.WriteLine("Price = Rs.500");
        }
    }
    class bigmac : burger
    {
        public int no_of_pattie;
        public bigmac()
        {
            Console.WriteLine("Big Mac burger");
        }
        public void Making()
        {
            Console.WriteLine("Big Mac burger includes");
            Console.WriteLine("No_of_pattie = {0}", no_of_pattie);
            Console.WriteLine("Lattice and Sauce");
        }
    }
    class program
    {
        static void Main()
        {
            bigmac bur = new bigmac();
            bur.fastfoodtype();
            bur.no_of_pattie = 2;
            bur.brand();
            bur.Making();
            bur.price();
            Console.ReadKey();
        }
    }
}

        
        
    


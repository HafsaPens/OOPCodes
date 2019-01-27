using System;

namespace override_methods_class
{
    class broast
    {
        public broast()
        {
            Console.WriteLine("Broast");
        }
        public virtual void making()
        {
            Console.WriteLine("chicken,breadcrum,redchilli powder,cornflour");
        }
    }
    class spicybroast : broast
    {
        public spicybroast()
        {
            Console.WriteLine("Spicy Brooast");
        }
        public override void making()
        {
            Console.WriteLine("chicken,breadcrum,red chilli powder,cornflour,crushed black pepper");
        }
    }
    class Program
    {
        static void Main()
        {
            spicybroast sp = new spicybroast();
            sp.making();
            Console.ReadKey();
        }
    }
}
        
        
        
    


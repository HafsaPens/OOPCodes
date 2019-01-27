using System;

namespace override_examplaycode
{
    class cloths
    {
        public cloths()
        {
            Console.WriteLine("pant,t-shirt,joggers,shalwar kameez,sandals");
        }
        public virtual void outlets_available()
        {
            Console.WriteLine("Guts,Khaadi,J.,Zeen,Threads");
        }
    }
    class western_cloths : cloths
    {
        public western_cloths()
        {
            Console.WriteLine("pant,t-shirt,joggers");
        }
        public override void outlets_available()
        {
            Console.WriteLine("Levi's,Outfitters");
        }
    }
    class Program
    {
        static void Main()
        {
            western_cloths west = new western_cloths();
            west.outlets_available();
            Console.ReadKey();
        }
    }
}

     
        
       
    


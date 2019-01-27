using System;
namespace Copy_Const.calss
{
    class Pretsuit
    {
        public string brand_pret = "0";
        public int size = 0;
        public double price = 0;
        public Pretsuit(string name_of_brand,int pret_size,double net_price)
        {
            brand_pret = name_of_brand;
            size = pret_size;
            price = net_price;
        }
        // copy constructor
        public Pretsuit(Pretsuit obj)
        {
            brand_pret = obj.brand_pret;
            size = obj.size;
            price = obj.price;
        }
    }
    class Program
    {
        static void Main()
        {
            Pretsuit obj1 = new Pretsuit("Khaadi", 10, 7000);
            Pretsuit obj2 = new Pretsuit(obj1);
            Console.WriteLine("pret brand name:{0}", obj2.brand_pret);
            Console.WriteLine("pretsize:{0}", obj2.size);
            Console.WriteLine("pretprice:{0}", obj2.price);
            Console.ReadKey();
        }
    }
}

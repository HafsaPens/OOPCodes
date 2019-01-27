using System;
    namespace ConsoleApp1
{
    class program
    {
        static void Main()
        {
            double CTEMP,FTEMP;
            Console.WriteLine("Enter temperature in degree celsius\n");
            CTEMP=double.Parse(Console.ReadLine());
            FTEMP = 1.8 *( CTEMP + 32);
            Console.WriteLine("Temperature in degree fahrenheit is{0}", FTEMP);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;



namespace Interrupt_handling
{

    class Processes
      
    {
        static int flag,mark,check_point;
        static void Block_Queue()   {
            if (flag == 1)
            {
                Console.WriteLine("Process1 has been sent to the Ready Queue after event call! ");
                for (int i = 15; i <= 25; i++)
                {
                    Console.WriteLine($"P1:{i}");
                }
            }
            if(mark==1)
                {
                Console.WriteLine("Process2 has been sent to the Ready Queue after the event call!");
                for(int i=10;i<=25;i++)
                {
                 
                    if(i==16)
                    {
                        Console.WriteLine($"P2:There's again a Software Interrupt in this process at instruction {i}");
                        Console.WriteLine("Process2 has been sent to the Block Queue!");
                        break;
                    }
                    Console.WriteLine($"P2:{i}");

                }



            }
            if (check_point == 1)
            {
                Console.WriteLine("Process4 has been sent to the Ready Queue after the event call!");
                for (int i = 15; i <= 25; i++)
                {

                    Console.WriteLine($"P4:{i}");
                }
                Console.WriteLine("Process2 has been sent to the Ready Queue after the event call!");
                for (int i = 16; i <= 25; i++)
                {
                    Console.WriteLine($"P2:{i}");

                }
            }

        }

        static void Process1() { 

            for (int i = 1; i <= 25; i++)
            {
                if (i == 15)
                {
                    flag = 1;
                    Console.WriteLine($"P1:There's a Software Interrupt in this process at instruction {i}");
                    Console.WriteLine("Process1 has been sent to the Block Queue!");
                    break;
                    // Thread.Sleep(15000);

                }
                Console.WriteLine($"P1:{i}");

            }
        }
        static void Process2()
        {


            for (int i = 1; i <= 25; i++)
            {
                if (i == 10)
                {
                    mark = 1;
                    Console.WriteLine($"P2:There's a Software Interrupt in this process at instruction {i}");
                    Console.WriteLine("Process2 has been sent to the Block Queue!");
                    break;


                }
                Console.WriteLine($"P2:{i}");

            }
        }

        static void Process3()
        { for (int i = 1; i <= 25; i++)
            {
               
                if (i == 5)
                {
                    
                    Console.WriteLine("P3:Its a Hardware interrupt in the second instruction...Press any key from keyboard to continue");
                    char a = Convert.ToChar(Console.ReadLine());

                    int b = a;// for converting that char into its ASCII Code
                    if (a <= 255)
                    {
                        Console.WriteLine("P3:Hardware interrupt has been resolved!");
                        Console.WriteLine("P3:You are good to go!");
                    }



                }
                Console.WriteLine($"P3:{i}");
            }

        }
        static void Process4()
        {

            for (int i = 1; i <= 25; i++)
            {
                if ( i == 15 )
                {
                    check_point=1;
                    Console.WriteLine($"P4:There's a Software Interrupt in this process at instruction {i}");
                    Console.WriteLine("Process4 has been sent to the Block Queue!");
                    break;
                

                }
                
                
               
                Console.WriteLine($"P4:{i}");

            }

        }

        public static void Main()
        { 
                Process1();
            Process2();
            Process3();

            Process4();
            Block_Queue();


            Console.ReadKey(); 

        }
    }
}
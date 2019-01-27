
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
namespace ShortestJobFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumofProcesses;
            int time, index = 0, index2 = 0, NumofProcessesArrived = 0, NumofProcessesTerminated = 0;
            bool ProcessAdded = false;
            Console.WriteLine("Enter number of processes to run");
            NumofProcesses = int.Parse(Console.ReadLine());
            int RemainingProcesses = NumofProcesses;
            ArrayList Processes = new ArrayList();
            string[] processes2 = new string[NumofProcesses];
            ArrayList ArrivalTime = new ArrayList();
            ArrayList BurstTime = new ArrayList();
            Random random = new Random();
            string[] ProcesstoRun = new string[NumofProcesses];
            ArrayList ProcessArrived = new ArrayList();
            ArrayList ProcessArrivedBurst = new ArrayList();
            for (int loop1 = 0; loop1 < NumofProcesses; loop1++)
            {
                processes2[loop1] = "Process " + loop1;
            }
            for (int loop1 = 0; loop1 < NumofProcesses; loop1++)
            {
                Processes.Insert(loop1, processes2[loop1]);
            }
            for (int loop1 = 0; loop1 < NumofProcesses; loop1++)
            {
                ArrivalTime.Insert(loop1, random.Next(0, 10));
                for (int j = 0; j < loop1; j++)
                {
                    if (Convert.ToInt32(ArrivalTime[loop1]) == Convert.ToInt32(ArrivalTime[j]))
                    {
                        loop1--;
                        break;
                    }
                }
            }
            for (int loop1 = 0; loop1 < NumofProcesses; loop1++)
            {
                BurstTime.Insert(loop1, random.Next(1, 10));
                for (int j = 0; j < loop1; j++)
                {
                    if (Convert.ToInt32(BurstTime[loop1]) == Convert.ToInt32(BurstTime[j]))
                    {
                        loop1--;
                        break;
                    }
                }
            }
            Console.WriteLine("Processes\t  Arrival Time\t   Burst Time");
            Console.WriteLine("---------\t  ------------\t   ----------");
            Console.WriteLine();
            for (int loop1 = 0; loop1 < NumofProcesses; loop1++)
            {
                Console.WriteLine(Processes[loop1] + "\t\t" + ArrivalTime[loop1] + "\t\t" + BurstTime[loop1]);
            }
            time = 0;
            do
            {
                for (int loop1 = 0; loop1 < RemainingProcesses; loop1++)
                {
                    if (Convert.ToInt32(ArrivalTime[loop1]) < time || Convert.ToInt32(ArrivalTime[loop1]) == time)
                    {

                        ProcessArrived.Insert(index2, Processes[loop1]);
                        NumofProcessesArrived++;
                        ProcessArrivedBurst.Insert(index2, BurstTime[loop1]);
                        index2++;

                    }
                }
                if (NumofProcessesArrived > 0)
                {
                    int smallestburst = Convert.ToInt32(ProcessArrivedBurst[0]);
                    ProcesstoRun[index] = ProcessArrived[0].ToString();
                    for (int loop1 = 1; loop1 < NumofProcessesArrived; loop1++)
                    {
                        if (smallestburst > Convert.ToInt32(ProcessArrivedBurst[loop1]))
                        {
                            smallestburst = Convert.ToInt32(ProcessArrivedBurst[loop1]);
                            ProcesstoRun[index] = ProcessArrived[loop1].ToString();
                            ProcessAdded = true;
                        }

                    }
                    for (int i = 0; i < RemainingProcesses; i++)
                    {
                        if (ProcesstoRun[index] == (Processes[i].ToString()))
                        {
                            Processes.RemoveAt(i);
                            ArrivalTime.RemoveAt(i);
                            BurstTime.RemoveAt(i);
                            RemainingProcesses--;
                            break;
                        }
                    }
                    if (ProcessAdded == true)
                    {
                        NumofProcessesTerminated++;
                        ProcessAdded = false;
                        index++;
                    }
                    else if (ProcessAdded == false)
                    {
                        NumofProcessesTerminated++;
                        index++;
                    }
                    index2 = 0;
                    NumofProcessesArrived = 0;
                    time = time + smallestburst;

                    //}
                }
                else
                {
                    time++;
                }
            } while (NumofProcessesTerminated != NumofProcesses);
            Console.WriteLine();
            for (int i = 0; i < NumofProcesses; i++)
            {
                Console.WriteLine("Running " + ProcesstoRun[i] + ". . .");
                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }

    }
}

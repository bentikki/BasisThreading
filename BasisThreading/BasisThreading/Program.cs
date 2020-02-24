using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasisThreading
{
    //Opgave 1 & 2
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Thread t1 = new Thread(Printer1);
    //        t1.Start();
    //        Thread t2 = new Thread(Printer2);
    //        t2.Start();
    //    }


    //    static void Printer1()
    //    {
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine("C#-trådning er nemt!");
    //            Thread.Sleep(1000);
    //        }   
    //    }

    //    static void Printer2()
    //    {
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine("...Også med flere tråde …");
    //            Thread.Sleep(1100);
    //        }
    //    }
    //}



    //class Program //Opgave 3
    //{
    //    static void Main(string[] args)
    //    {
    //        Thread t1 = new Thread(Printer1);
    //        t1.Start();
    //        t1.Join();

    //        Console.WriteLine();
    //        Console.WriteLine("The Alert thread has been terminated!");
    //        Console.WriteLine("Press any key to end the program...");
    //        Console.ReadKey();
    //    }


    //    static void Printer1()
    //    {
    //        Random r = new Random();
    //        int numberOfWarnings = 0;
    //        do
    //        {
    //            int temp = r.Next(-20, 120);

    //            Console.WriteLine("The temperature is {0} C", temp);

    //            if(temp < 0 || temp > 100)
    //            {
    //                numberOfWarnings++;
    //                Console.WriteLine("Alert #{0}! The temperature is not within parameters!", numberOfWarnings);
    //            }
    //            Thread.Sleep(2000);

    //        } while (numberOfWarnings < 3);
    //    }

    //}


    //Opgave 4 


    class Program //Opgave 4
    {
        static Char ch = '*';

        static void Main(string[] args)
        {
            Thread printerThread = new Thread(Printer);
            printerThread.Start();

            Thread readerThread = new Thread(Reader);
            readerThread.Start();

        }


        static void Printer()
        {
            while (true)
            {
                Console.Write(ch);
                Thread.Sleep(100);
            }
        }

        static void Reader()
        {
            while (true)
            {
                ch = Console.ReadKey().KeyChar;   
            }
        }

    }
}

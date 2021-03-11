using System;
using System.Collections.Generic;
using System.Threading;

namespace bus
{
    class Bus
    {
        public int time;
        public int mest;
  
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stop bus1 = new Stop();
            Stop bus2 = new Stop();
            Stop bus3 = new Stop();
                  Stop bus4 = new Stop();
                  Stop bus5 = new Stop();
            for (int i = 0; i < 50; i++, Thread.Sleep(50))
            {
                Console.WriteLine("автобус");
                bus1.Go();
                Thread.Sleep(50);
                Console.WriteLine("автобус");
                bus2.Go();
                Thread.Sleep(50);
                Console.WriteLine("автобус");
                bus3.Go();
                Console.WriteLine("          ");
            }
        }
    }
    public class Stop
    {

        List<Bus> Bus = new List<Bus>();
        int fd = 0;
        double sum = 0;
        int hv;
        public void pasag()
        {
            Random rnd = new Random(); 
            int kilk = rnd.Next(0, 20); ;
            Console.WriteLine("На остановке: " + kilk);
            for (int i = 0 ; i < kilk ; i++)
            { 
                hv = rnd.Next(1, 20);
                sum += hv;
                fd++;
            }
            sum = fd / sum;
            Console.WriteLine("середне время ожидания: "+ sum);
            sit(kilk);
        }



        public void sit(int kilk)
        {
            Random rnd = new Random();
            int mest = rnd.Next(0, 35);
            Console.WriteLine("мест в автобусе: " + mest);
            int time = 10;
            if (kilk <= mest)
            {   mest = mest - kilk;
                kilk = 0;
            }
            else if(kilk > mest) {
                int f = 35 - mest;
                kilk = kilk - mest;
                mest = 0;
            }
                Console.WriteLine("Свободных мест в автобусе после посадки: " + mest);
            Bus.Add(new Bus() { time = time, mest = mest });
            Console.WriteLine("людей на остановке после автобуса: " + kilk);
        }

        public void Go()
        {
            pasag();
           // busmest();
           // GetInfo();
            sit(0);
        }
    }
}

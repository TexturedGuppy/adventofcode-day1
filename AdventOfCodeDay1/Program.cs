using System;
using System.IO;

namespace AdventOfCodeDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            string line;
            int counter = 0;
            int totalFuel = 0;
            int fuelFuel;
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                //String line = sr.ReadToEnd();
                //Console.WriteLine(line);
            }
            StreamReader file = new StreamReader("input.txt");
            while ((line = file.ReadLine()) != null)
            {
                counter++;
                Console.WriteLine("Total Fuel So Far: " + (totalFuel += P.calculateFuel(Convert.ToInt32(line), counter)));
            }

            //fuelFuel = P.calculateFuel(totalFuel);

            //totalFuel += P.calculateFuelForFuel(fuelFuel);
            Console.WriteLine("Total Fuel Required: " + totalFuel);

        }

        public int calculateFuel(int moduleMass, int counter)
        {
            Program P = new Program();
            int fuelReq;
            fuelReq = (moduleMass / 3) - 2;
            fuelReq += P.calculateFuelForFuel(fuelReq);
            return fuelReq;
        }

        public int calculateFuelForFuel(int fuel)
        {
            int fuelReq;
            fuelReq = (fuel / 3) - 2;
            Console.WriteLine("Fuel Requirement in Recursive Function: " + fuelReq);
            if (fuelReq <= 0)
            {
                return 0;
            }
            return fuelReq+calculateFuelForFuel(fuelReq);
        }
    }
}
                

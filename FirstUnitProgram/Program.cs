using System;

namespace FirstUnitProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2022, 08, 17);
            var time = (DateTime.Now.Date.Subtract(date).Days);
            if (time > 0)
                Console.WriteLine(time);
            else
                Console.WriteLine("Time: " + time.ToString());

            Console.ReadLine(); 
        }
    }
}

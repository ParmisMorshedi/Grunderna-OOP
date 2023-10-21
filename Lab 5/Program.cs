using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle mycircle1 = new Circle(5);
            Circle mycircle2 = new Circle(6);

         
         

            Console.WriteLine($"Arean på cirke1 med radie 5 är: {mycircle1.GetArea()}");
            Console.WriteLine($"Arean på cirke2 med radie 6 är: {mycircle2.GetArea()}"); 

            Console.WriteLine($"Omkretsen på cirke1 med radie 5 är: {mycircle1.GetOmkrets()}");
            Console.WriteLine($"Omkretsen på cirke2 med radie 6 är: {mycircle2.GetOmkrets()}");

            Console.WriteLine($"Volymen på cirke1 med radie 5 är: {mycircle1.GetVolym()}");
            Console.WriteLine($"Volymen på cirke2 med radie 6 är: {mycircle2.GetVolym()}");

        }
    }
}

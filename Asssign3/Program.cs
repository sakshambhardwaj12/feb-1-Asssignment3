using System;

namespace Asssign3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter marks in physics");
            int physics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks in chemistry");
            int chemistry = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks in maths");
            int maths = int.Parse(Console.ReadLine());

            Eligible e = new Eligible(physics,chemistry,maths);
            e.eligibility();

        }
    }
}

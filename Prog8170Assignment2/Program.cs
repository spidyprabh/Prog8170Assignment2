using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170Assignment2
{
  class Program
  {
    static void Main(string[] args)
    {
      
      int choice, l, b, h;
        // initialize variable

      do
      {
        Console.WriteLine("Choose the correct options: ");
        Console.WriteLine("1.Enter triangle dimensions");
        Console.WriteLine("2.Exit");
        if ((!int.TryParse(Console.ReadLine(), out choice) || choice <= 0 || choice > 2)) // check user input
        {
          Console.WriteLine("Please Enter the Correct Choice: ");
          continue;
        }
          switch (choice)
        { 
          case 1:
            do {
              Console.WriteLine("Please Enter the First Side of the Triangle: ");
            } while (!int.TryParse(Console.ReadLine(), out l));
            do {
              Console.WriteLine("Please Enter the Second Side of the Triangle: ");
            } while(!int.TryParse(Console.ReadLine(), out b));
            do {
              Console.WriteLine("Please Enter the third Side of the Triangle: ");
            } while (!int.TryParse(Console.ReadLine(), out h));
            Console.WriteLine(TriangleSolver.Analyze(l, b, h));
            break;

          case 2:
            Environment.Exit(0);
            break;
        } 
        
      } while (choice!=2);

    }
  }
}

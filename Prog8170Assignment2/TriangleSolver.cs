using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170Assignment2
{
 public static class TriangleSolver
  {
    
    public static string Analyze(int l,int b, int h)
    {
      if ((l + b) > h || (b + h) > l)
        return "Triangle can be formed";
      else
        return "Triangle cannot be formed";
    }

    public static string Triangle(int l, int b, int h)
    {
      if ((l == b) && (b== h))
        return "This is an Equilateral Triangle";
      else if ((l == b) || (l == h) || (b ==h))
        return "This is an Isosceles Triangle";
      else return "This is an Scalene Triangle";
     }




  }
}

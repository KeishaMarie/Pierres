using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int NumLoaves { get; set; }

    public Bread(int numloaves)
    {
      NumLoaves = numloaves;
    }

    
    public static int BreadPrice(int numLoaves)
    {

      if (numLoaves == 1)
      {
        return 5;
      }
      else if (numLoaves == 2)
      {
        return 10;
      }
      else if (numLoaves >=3)
      {
        decimal breadDeal = Decimal.Floor(numLoaves/3);
        int stringToInt = Convert.ToInt32(breadDeal);
        return ((numLoaves - stringToInt)*5);
      }
      else
      {
        return 0;
      }
    }
  }

}
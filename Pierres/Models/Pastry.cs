using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int NumPastries { get; set;}

    public Pastry(int numPastries)
    {
      NumPastries = numPastries;
    }
    public int PastryPrice(int numPastries)
    {
      if (numPastries == 1)
      {
        return 2;
      }
      else if (numPastries == 3 || numPastries == 4 || numPastries == 5)
      {
        return ((numPastries * 2) - 1);
      }
      else if (numPastries > 5)
      {
        decimal pastryDeal = Decimal.Floor(numPastries / 6);
        int convertToInt = Convert.ToInt32(pastryDeal);
        return ((numPastries * 2) - (convertToInt * 2));
      }
      else
      {
        return numPastries * 2;
      }
    }
  }
}
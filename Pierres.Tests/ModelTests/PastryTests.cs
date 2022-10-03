using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Test
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryPrice_OnePastryPrice_Int()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(2, newPastry.PastryPrice(1));
    }

    [TestMethod]
    public void PastryPrice_twoPastryPrice_int()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(4, newPastry.PastryPrice(2));
    }
  }
}
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
    public void PastryPrice_TwoPastryPrice_int()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(4, newPastry.PastryPrice(2));
    }

    [TestMethod]
    public void PastryPrice_ThreePastryPrice_Int()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(5, newPastry.PastryPrice(3));
    }

    [TestMethod]
    public void PastryPrice_FourPastryPrice_Int()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(7, newPastry.PastryPrice(4));
    }

    [TestMethod]
    public void PastryPrice_FivePastryPrice_Int()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(9, newPastry.PastryPrice(5));
    }

    [TestMethod]
    public void PastryPrice_SixPastryPrice_Int()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(10, newPastry.PastryPrice(6));
    }
  }
}
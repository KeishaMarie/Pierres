using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Test
{
  [TestClass]
  
  public class BreadTests
  {
    [TestMethod]
    public void BreadPrice_OneLoafPrice_True()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(5, newBread.BreadPrice(1));
    }

    [TestMethod]
    public void BreadPrice_TwoLoavesPrice_True()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(10, newBread.BreadPrice(2));
    }
  }
}
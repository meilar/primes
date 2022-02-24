using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Primes.Tests
{
  [TestClass]
  public class SifterTests
  {
    [TestMethod]
    public void ListBuilder_CreatesSifter_List()
    {
      List<int> newList = Primes.Models.Sifter.ListBuilder(2);
      Assert.AreEqual(typeof(List<int>), newList.GetType());
    }
  }
}
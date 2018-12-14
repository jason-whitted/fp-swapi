using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swapi.Models;

namespace Swapi.Tests.Unit
{
  [TestClass]
  public partial class SwapiTests
  {
    [TestMethod]
    public void ShouldGet()
    {
      var root = RestApi.Get<Root>("https://swapi.co/api");
      Assert.AreEqual("https://swapi.co/api/films/", root.FilmsUrl);
    }
  }
}
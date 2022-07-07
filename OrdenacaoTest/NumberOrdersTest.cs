using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdenacaoAPI.Models;

namespace OrdenacaoTest;
[TestClass]
public class NumberOrdersTest
{
    [TestMethod]
    public void ChangeTest()
    {
        int[] expected = new int[]{4,6};
        int[] result;

        NumberOrders numbers = new NumberOrders();
        result = numbers.Change(6,4);

        CollectionAssert.AreEqual(expected, result);
        
    }

    [TestMethod]
    public void MenostestPositivo()
    {
        int expected = -2;
        int result;

        NumberOrders numbers = new NumberOrders();
        result = numbers.Menos(2);
        Assert.AreEqual(expected, result);
        
    }

    [TestMethod]
    public void MenostestNegativo()
    {
        int expected = -2;
        int result;

        NumberOrders numbers = new NumberOrders();
        result = numbers.Menos(-2);
        Assert.AreEqual(expected, result);
        
    }
}
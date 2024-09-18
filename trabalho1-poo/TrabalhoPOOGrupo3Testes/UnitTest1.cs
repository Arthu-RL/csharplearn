using soma;
using milimetros;
using bhaskara;

namespace TrabalhoPOOGrupo3Testes;

using TrabalhoPOOGrupo3;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void TestSum()
    {
        int sum = soma.Soma.Sum(20000, 20000);
        Assert.AreEqual(40000, sum);
        Assert.AreNotEqual(40001, sum);
    }

        [TestMethod]
        public void TestSumFailure()
        {
            int sum = soma.Soma.Sum(20000, 20000);

            // Dar errado
            Assert.AreEqual(40001, sum);
        }

    [TestMethod]
    public void TestMetersToMillimeters()
    {
        int millimeters = milimetros.Milimetros.MetersToMillimeters(100);
        Assert.AreEqual(100000, millimeters);
        Assert.AreNotEqual(100001, millimeters);
    }

    [TestMethod]
    public void TestMetersToMillimetersFailure()
    {
        int millimeters = milimetros.Milimetros.MetersToMillimeters(100);

        // Dar errado
        Assert.AreEqual(100001, millimeters);
    }

    [TestMethod]
    public void TestBhaskara()
    {
        double bhaskaraCalc = bhaskara.BhaskaraCalc.Bhaskara(80, 20, 40);
        Assert.AreEqual(3200, bhaskaraCalc);
        Assert.AreNotEqual(3200.5, bhaskaraCalc);
    }

    [TestMethod]
    public void TestBhaskaraFailure()
    {
        double bhaskaraCalc = bhaskara.BhaskaraCalc.Bhaskara(80, 20, 40);

        // Dar errado
        Assert.AreEqual(32000, bhaskaraCalc);
    }

    [TestMethod]
    public void TestRentCar()
    {
        Car car = new Car("AUDI", 2042, "AU777", 600.00);
        double rent = car.CalculateRentPrice(10);
        Assert.AreEqual(6000.00, rent);
        Assert.AreNotEqual(6000.20, rent);
    }

    [TestMethod]
    public void TestRentCarFailure()
    {
        Car car = new Car("AUDI", 2042, "AU777", 600.00);
        double rent = car.CalculateRentPrice(10);

        // Dar errado
        Assert.AreEqual(6000.20, rent);
    }
}

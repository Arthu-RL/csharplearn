namespace TestProject;

using calc;
using utils;

[TestClass]
public class ContainerTest
{
    [TestMethod]
    public void AddToCapacityTest()
    {
        var container = new Container(10);

        container.AddToCapacity(10);

        Assert.AreEqual(20, container.GetCapacity());
    }
}
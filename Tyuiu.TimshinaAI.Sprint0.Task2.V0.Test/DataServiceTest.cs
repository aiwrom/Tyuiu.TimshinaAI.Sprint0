using Tyuiu.TimshinaAI.Sprint0.Task2.V0.Lib;
namespace Tyuiu.TimshinaAI.Sprint0.Task2.V0.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CheckGetMessageValid()
    {
        var name = "Арина";
        var res = DataService.GetMessage(name);
        Assert.AreEqual("Привет,Арина", res);
        Assert.Pass();
    }
}
using Tyuiu.TimshinaAI.Sprint0.Task5.V0.Lib;
namespace Tyuiu.TimshinaAI.Sprint0.Task5.V0.Test;

public class DataServiceTest
{
    [Test]
    public void CheckedAdditionValid()
    {
        Assert.AreEqual(10, DataService.Addition(5, 5));
    }

    [Test]
    public void CheckedSubtractionValid()
    {
        Assert.AreEqual(5, DataService.Subtraction(10, 5));
    }
    
    [Test]
    public void CheckedMultiplicationValid()
    {
        Assert.AreEqual(10, DataService.Multiplication(10, 5));
    }
    
    [Test]
    public void CheckedDivisionValid()
    {
        Assert.AreEqual(5, DataService.Division(9, 3));
    }
}
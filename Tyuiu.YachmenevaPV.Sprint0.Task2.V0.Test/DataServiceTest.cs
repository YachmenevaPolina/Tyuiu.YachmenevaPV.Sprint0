using Tyuiu.YachmenevaPV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.YachmenevaPV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Полина";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Полина", res);
        }
    }
}

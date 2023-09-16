using CarApplication;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Car car = new CarBuilder()
                .SetColor("Grey").SetPrice(1000000).SetGeneration(11).SetCompany("Porsche").SetType("SUV")
                .Build();
            Assert.IsTrue(car.color == "Grey");
            Assert.IsTrue(car.price == 1000000);
            Assert.IsTrue(car.generation == 11);
            Assert.IsTrue(car.company == "Porsche");
            Assert.IsTrue(car.type == "SUV");
        }
    }
}
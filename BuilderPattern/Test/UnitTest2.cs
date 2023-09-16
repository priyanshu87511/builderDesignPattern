using CarApplication;

namespace Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {

            Car car = new CarBuilder()
                .SetColor("Grey").SetCompany("Porsche").SetType("SUV")
                .Build();
            Assert.IsTrue(car.color == "Grey");
            Assert.IsTrue(car.company == "Porsche");
            Assert.IsTrue(car.type == "SUV");
        }
    }
}
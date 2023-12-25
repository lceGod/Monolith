using NUnit;
using Domain;

namespace Tests
{

    [TestClass]
    public class PlacementTests
    {
        [TestMethod]
        public void ToStringTest() // тест проверяющий метод ToString для Placement
        {
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                double count = rand.NextDouble() * 100;
                var pl = new Placement("Имя помещения", true);
                Assert.AreEqual("Имя помещения " + true, pl.ToString());
            }
        }
        [TestMethod]
        public void ConstructorTest()
        {
            string expectedName = "TestName";
            bool expectedIsStorage = true;

            Placement placement = new Placement(expectedName, expectedIsStorage);

            Assert.AreEqual(expectedName, placement.Name);
            Assert.AreEqual(expectedIsStorage, placement.IsStorage);
        }

        [TestMethod]
        public void InitializedMaterialsListTest()
        {
            Placement placement = new Placement("TestName", true);

            Assert.IsNotNull(placement.Materials);
        }

        [TestMethod]
        public void EqualsTest()
        {
            Placement placement1 = new Placement("TestName1", true);
            Placement placement2 = new Placement("TestName1", true);

            Assert.AreEqual(placement1.Equals(placement2), true);
        }

        [TestMethod]
        public void OperatorParesTest()
        {
            Placement placement1 = new Placement("TestName1", true);
            Placement placement2 = new Placement("TestName1", true);

            Assert.AreEqual(placement1 == placement2, true);
        }

        [TestMethod]
        public void OperatorNoParesTest()
        {
            Placement placement1 = new Placement("TestName1", true);
            Placement placement2 = new Placement("TestName1", true);

            Assert.AreEqual(placement1 != placement2, false);
        }
    }
}

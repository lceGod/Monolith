using NUnit;
using Domain;

namespace Tests
{

    [TestClass]
    public class PlacementTests
    {
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

    }
}

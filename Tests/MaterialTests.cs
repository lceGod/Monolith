using NUnit;
using Domain;

namespace Tests
{
    [TestClass]
    public class MaterialTests
    {
        [TestMethod]
        public void ToStringTest() //  тест проверяющий метод ToString для Material
        {
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                double count = rand.NextDouble() * 100;
                var mat = new Material("Имя материала", count, "Шт.", 0);
                Assert.AreEqual("Имя материала " + Math.Round(count, 2) + " Шт.", mat.ToString());
            }
        }

        [TestMethod]
        public void CountSetterTest() // тест на правильную работу сеттера количества материала.
        {
            Random rand = new Random();
            Material mat;
            double count;

            for (int i = 0; i <= 100; i++) 
            {
                count = rand.NextDouble();
                mat = new Material("Имя материала", count, "Шт.", 0);
                Assert.AreEqual(count, mat.Count);
            }

            try
            {
                count = (rand.NextDouble() - 1);
                mat = new Material("Имя материала", count, "Шт.", 0);
                Assert.Fail();
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void LimitSetterTest() // тест на правильную работу сеттера лимита материала.
        {
            Random rand = new Random();
            Material mat;
            double limit;

            for (int i = 0; i <= 100; i++)
            {
                limit = rand.NextDouble();
                mat = new Material("Имя материала", 0, "Шт.", limit);
                Assert.AreEqual(limit, mat.Limit);
            }

            try
            {
                limit = (rand.NextDouble() - 1);
                mat = new Material("Имя материала", 0, "Шт.", limit);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void EqualsTest()
        {
            Material material1 = new Material("Цемент", 20, "т", 0);
            Material material2 = new Material("Цемент", 20, "т", 0);

            Assert.AreEqual(material1.Equals(material2), true);
        }

        [TestMethod]
        public void OperatorParesTest()
        {
            Material material1 = new Material("Цемент", 20, "т", 0);
            Material material2 = new Material("Цемент", 20, "т", 0);

            Assert.AreEqual(material1 == material2, true);
        }

        [TestMethod]
        public void OperatorNoParesTest()
        {
            Material material1 = new Material("Цемент", 20, "т", 0);
            Material material2 = new Material("Цемент", 20, "т", 0);

            Assert.AreEqual(material1 != material2, false);
        }

    }

}

using TriangleSolver;

namespace TestaA2
{
    [TestFixture]
    public class DifferentTriangleTests
    {

        public void SetupTriangles()
        {
        }

        [Test]                  //Test 1
        public void Test_AnalyzeTriangle_inpput40and40and40_EQUILATERAL()
        {   // 1A
            int side_one = 40;
            int side_two = 40;
            int side_three = 40;
            String expectResult = "The triangle is valid and is an EQUILATERAL";

            // 2A
            string actResult = Triangle.AnalyzeTriangle(side_one, side_two, side_three);
            //3A
            Assert.AreEqual(expectResult, actResult);

        }

        [Test]                  //Test 2
        public void Test_AnalyzeTriangle_inpput60and60and70_ISOSCELES()
        {   // 1 A
            int side_one = 60;
            int side_two = 60;
            int side_three = 70;
            String expectResult = "The triangle is valid and is an ISOSCELES";

            // 2 A
            string actResult = Triangle.AnalyzeTriangle(side_one, side_two, side_three);
            Console.WriteLine(actResult);

            //3 A
            Assert.AreEqual(expectResult, actResult);

        }

        [Test]                  //Test 3
        public void Test_AnalyzeTriangle_inpput45and80and45_ISOSCELES()
        {   // 1 A
            int side_one = 45;
            int side_two = 80;
            int side_three = 45;
            String expectResult = "The triangle is valid and is an ISOSCELES";

            // 2 A
            string actResult = Triangle.AnalyzeTriangle(side_one, side_two, side_three);
            Console.WriteLine(actResult);

            //3 A
            Assert.AreEqual(expectResult, actResult);

        }
    }

       
}
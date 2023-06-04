using TriangleSolver;

namespace TestaA2
{
    public class DifferentTriangleTests
    {
        [SetUp]
        public void SetupTriangles()
        {
        }

        [Test]                  //Test 1
        public void Test_AnalyzeTriangle_inpput40and40and40_EQUILATERAL()
        {   // 1 A
            int side_one = 40;
            int side_two = 40;
            int side_three = 40;
            String expectResult = "The triangle is valid and is an EQUILATERAL";

            // 2 A
            string actResult = Triangle.AnalyzeTriangle(side_one, side_two, side_three);
            Console.WriteLine(actResult);
            //3 A
            StringAssert.AreEqualIgnoringCase(expectResult, actResult);
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
            StringAssert.AreEqualIgnoringCase(expectResult, actResult);
        }



    }
}
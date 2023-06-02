using TriangleSolver;

namespace TestaA2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_AnalyzeTriangle_inpput40and40and40_EQUILATERAL()
        {   // 1 A
            int input1 = 40;
            int input2 = 40;
            int input3 = 40;
            String expectResult = "The triangle is valid and is an EQUILATERAL";

            // 2 A
            string ret = Triangle.AnalyzeTriangle(input1, input2, input3);
            Console.WriteLine(ret);
            //3 A
            StringAssert.AreEqualIgnoringCase(expectResult,ret);
        }

        [Test]
        public void Test_AnalyzeTriangle_inpput60and60and70_ISOSCELES()
        {   // 1 A
            int input1 = 60;
            int input2 = 60;
            int input3 = 70;
            String expectResult = "The triangle is valid and is an ISOSCELES";

            // 2 A
            string ret = Triangle.AnalyzeTriangle(input1, input2, input3);
            Console.WriteLine(ret);
            //3 A
            StringAssert.AreEqualIgnoringCase(expectResult, ret);
        }



    }
}
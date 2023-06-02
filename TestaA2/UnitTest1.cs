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
        public void Test_AnalyzeTriangle_inpput25and25and25_EQUILATERAL()
        {   // 1 A
            int input1 = 30;
            int input2 = 30;
            int input3 = 30;
            String expectResult = "The triangle is valid and is an EQUILATERAL";

            // 2 A
            string ret = Triangle.AnalyzeTriangle(input1, input2, input3);
            Console.WriteLine(ret);
            //3 A
            StringAssert.AreEqualIgnoringCase(expectResult,ret);
        }

      
       
    }
}
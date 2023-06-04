using NUnit.Framework;
using TriangleSolver;

namespace TestaA2
{
    [TestFixture]
    public class DifferentTriangleTests
    {

        [Test]                  //Test 1 EQUILATERAL
        public void Test_AnalyzeTriangle_inpput40and40and40_EQUILATERAL()
        {   // 1 Arrange
            int side_one = 40;
            int side_second = 40;
            int side_third = 40;
            String expectResult = "The triangle is valid and is an EQUILATERAL";

            // 2 Act
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);

            //3 Assert
            Assert.AreEqual(expectResult, actResult);

        }

        [Test]                  //Test 1 for ISOSCELE
        public void Test_AnalyzeTriangle_inpput60and60and70_ISOSCELES()
        {   // 1 Arrange
            int side_one = 60;
            int side_second = 60;
            int side_third = 70;
            String expectResult = "The triangle is valid and is an ISOSCELES";

            // 2 Act
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.AreEqual(expectResult, actResult);

        }

        [Test]                  //Test 2 for ISOSCELE
        public void Test_AnalyzeTriangle_inpput45and80and45_ISOSCELES()
        {   // 1 Arrange
            int side_one = 45;
            int side_second = 80;
            int side_third = 45;
            String expectResult = "The triangle is valid and is an ISOSCELES";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.AreEqual(expectResult, actResult);

        }

        [Test]                  //Test 3 for ISOSCELE
        public void Test_AnalyzeTriangle_inpput27and20and20_ISOSCELES()
        {   // 1 Arrange
            int side_one = 27;
            int side_second = 20;
            int side_third = 20;
            String expectResult = "The triangle is valid and is an ISOSCELES";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.That(actResult, Is.EqualTo(expectResult));

        }

        [Test]                  //Test 1 for SCALENE
        public void Test_AnalyzeTriangle_inpput23and35and26_SCALENE()
        {   // 1 Arrange
            int side_one = 23;
            int side_second = 35;
            int side_third = 26;
            String expectResult = "The triangle is valid and is a SCALENE";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.AreEqual(expectResult, actResult);

        }


        [Test]                  //Test 2 for SCALENE
        public void Test_AnalyzeTriangle_inpput290and340and520_SCALENE()
        {   // 1 Arrange
            int side_one = 290;
            int side_second = 340;
            int side_third = 520;
            String expectResult = "The triangle is valid and is a SCALENE";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.That(actResult, Is.EqualTo(expectResult));

        }

        [Test]                  //Test 3 for SCALENE
        public void Test_AnalyzeTriangle_inpput53and25and56_SCALENE()
        {   // 1 Arrange
            int side_one = 53;
            int side_second = 25;
            int side_third = 56;
            String expectResult = "The triangle is valid and is a SCALENE";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.AreEqual(expectResult, actResult);

        }

        [Test]                  //Test 4 for SCALENE
        public void Test_AnalyzeTriangle_inpput140and75and90_SCALENE()
        {   // 1 Arrange
            int side_one = 140;
            int side_second = 75;
            int side_third = 90;
            String expectResult = "The triangle is valid and is a SCALENE";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.That(actResult, Is.EqualTo(expectResult));

        }
        [Test]                  //Test 5 for SCALENE
        public void Test_AnalyzeTriangle_inpput390and450and260_SCALENE()
        {   // 1 Arrange
            int side_one = 390;
            int side_second = 450;
            int side_third = 260;
            String expectResult = "The triangle is valid and is a SCALENE";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.That(actResult, Is.EqualTo(expectResult));

        }

        [Test]                  //Test 1 for ZERO LENGTH 
        public void Test_AnalyzeTriangle_inpput0and60and78_ZEROLENGTHSIDE()
        {   // 1 Arrange
            int side_one = 0;
            int side_second = 60;
            int side_third = 78;
            String expectResult = "At least one side of your triangle has a zero length and is thus invalid";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.AreEqual(expectResult, actResult);
        }

        [Test]                  //Test 2 for ZERO LENGTH 
        public void Test_AnalyzeTriangle_inpput0and90and0_ZEROLENGTHSIDE()
        {   // 1 Arrange
            int side_one = 0;
            int side_second = 90;
            int side_third = 0;
            String expectResult = "At least one side of your triangle has a zero length and is thus invalid";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.AreEqual(expectResult, actResult);

        }

        [Test]                  //Test 3 for ZERO LENGTH 
        public void Test_AnalyzeTriangle_inpput43and25and0_ZEROLENGTHSIDE()
        {   // 1 Arrange
            int side_one = 43;
            int side_second = 25;
            int side_third = 0;
            String expectResult = "At least one side of your triangle has a zero length and is thus invalid";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.AreEqual(expectResult, actResult);
        }

        [Test]                  //Test 1 for AN INVALID RESPONSE
        public void Test_AnalyzeTriangle_inpput10and22and34_INVALIDRESPONSE()
        {   // 1 Arrange
            int side_one = 10;
            int side_second = 22;
            int side_third = 34;
            String expectResult = "A triangle cannot be formed with those numbers";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.AreEqual(expectResult, actResult);

        }

        [Test]                  //Test 2 for AN INVALID RESPONSE
        public void Test_AnalyzeTriangle_inpput90and40and28_INVALIDRESPONSE()
        {   // 1 Arrange
            int side_one = 90;
            int side_second = 40;
            int side_third = 28;
            String expectResult = "A triangle cannot be formed with those numbers";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.That(actResult, Is.EqualTo(expectResult));

        }

        [Test]                  //Test 3 for AN INVALID RESPONSE
        public void Test_AnalyzeTriangle_inpput10and20and40_INVALIDRESPONSE()
        {   // 1 Arrange
            int side_one = 10;
            int side_second = 20;
            int side_third = 40;
            String expectResult = "A triangle cannot be formed with those numbers";

            // 2 Act 
            string actResult = Triangle.AnalyzeTriangle(side_one, side_second, side_third);
            Console.WriteLine(actResult);

            //3 Assert
            Assert.AreEqual(expectResult, actResult);

        }

    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//CLoing second time

//namespace NUnitSelenium.NUNITTests
//{
//    [Allure.NUnit.AllureNUnit]
//    internal class Assertions
//    {
//        [Test]
//        public void testassertions()
//        {
//            string actual = "google";
//            string expected = "yahoo";

//            //if (actual == expected)
//            //{
//            //    Console.Write("Results are matching");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Results not matching");
//            //} //here it runs but just shows output

//            Assert.AreEqual(actual, expected); //here Assert is a class
//            //assertion fails then testcase also fails

//            Assert.AreNotEqual(actual, expected);

//            //Assert that
//            Assert.That(actual, Is.EqualTo(expected));

//            Assert.That(actual, Is.Not.EqualTo(expected));

//            //assert for strings ignore case
//            Assert.That(actual, Is.EqualTo(expected).IgnoreCase);

//            //presence of your substring inside a string
//            Assert.That(actual, Does.Contain("def").IgnoreCase);
//            Assert.That(actual, Does.Not.Contain("def").IgnoreCase);

//            //empty assertions
//            Assert.IsEmpty(actual);
//            Assert.That(actual, Is.Empty);
//            Assert.IsTrue(actual.Equals(expected));
//            Assert.IsNull(actual);
//            Assert.IsNotNull(actual);
//            //collection  constraints
//            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

//            //not null
//            Assert.NotNull(array);

//            //greater than
//            Assert.That(array, Is.All.GreaterThan(0));

//            //empty
//            Assert.That(array, Is.Empty);
//            Assert.That(array, Is.Not.Empty);
//            //asc r desc order
//            Assert.That(array, Is.Ordered.Ascending);

//            //custom Assertions
//            int Age = 17;
//            if (Age <= 18)
//            {
//                throw new AssertionException("User is not eligible for voting");
//            }
//        }

//    }
//}

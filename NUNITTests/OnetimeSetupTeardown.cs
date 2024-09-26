using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUNITTests
{
    //identifies the class containing one time setup and tear down
    [SetUpFixture] //add this at class level - check....set the setup fixture for test now

    internal class OnetimeSetupTeardown //BaseClass.cs
    {
       
        [OneTimeSetUp] //identifies the method to be called just once==>db connopen-test cases-close db once
        //applicable at class level
        public void dbconnectionopen()
        {
            //doesntwork here->Console.WriteLine("Opening the DB connection");
            TestContext.Progress.WriteLine("Opening DB");
        }


        [OneTimeTearDown]
        public void dbconnectionclose()
        {
            //Console.WriteLine("Closing the DB conncetion");
            //base class-Test.cs-not crret

            TestContext.Progress.WriteLine("Closing DB");
        }
    }
}
//have to open Test1.cs and run it there....that time o/p - opening-first testcase-closing

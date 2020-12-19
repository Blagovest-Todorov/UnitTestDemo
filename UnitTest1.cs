using Microsoft.VisualStudio.TestTools.UnitTesting;  //MSTest Framework -supports unitTesting in Visual Studio
using System;

namespace DemosTests
{
    [TestClass]   // says that this class will be unit Test// this class will be unit Test Class !
    public class UnitTest1
    {
        private void SetUp() 
        {
          
        }

        [TestMethod]  // this method will be unit method test, this method will be a unit Test
       // [ExpectedException(typeof(DivideByZeroException))]
        public void Test_Demo ()
        {
            var zero = 0;
            var result = 1 / zero;
            // if expected result === actual result then the Test is passed, 
            // if the expected result != actual result after perforaming the code the Test i failed !
        }
    }
}

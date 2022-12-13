using System;
using System.Text.RegularExpressions;
using Day24_Lambda_Regex;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {///Arrange           
        [TestMethod]
        [DataRow("Ravi@123#%")]//test input 01 will pass test
        [DataRow("Raju")]//test input 02 will pass test
        [DataRow("raJu")]//test input 03   will fail test
        public void TestMethod(string name)
        {
            ///Act
            bool result = LambdaRegex.Validate(name);
            ///Assert
            Assert.AreEqual(true, result);
        }
    }
}
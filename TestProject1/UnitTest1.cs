using System;
using System.Text.RegularExpressions;
using Day24_Lambda_Regex;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {///Arrange           
        [TestMethod]
        [DataRow("@9703718299")]//test input 01 
         public void TestMethod(string input)
        {
            ///Act
            bool result = LambdaRegex.Validate(input);
            ///Assert
            Assert.AreEqual(true, result);
        }
    }
}
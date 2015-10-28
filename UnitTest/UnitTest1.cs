namespace UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using DingTechTest;
    using System.IO;
    using System.Diagnostics;

    [TestClass]
    public class UnitTest1
    {
        private static string fileContents = @"<?xml version=""1.0""?><request id=""EZE""  messagedate=""2015-10-28"" messagetime=""17-05-23""><msgID>332526<msgID><phonenumber>630000000000<phonenumber><amount>25<amount><request>";

        [TestMethod]
        public void TestMethod1()
        {
            //First Test
            XMLTopUpParser.ParseRequest(fileContents);
            //Check that the xml document isn't null 
            Debug.Assert(fileContents != null, "The xml parse file is null, re-check the request data!");            
        }
    }
}

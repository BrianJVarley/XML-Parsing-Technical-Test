﻿namespace UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using DingTechTest;
    using System.IO;
    using System.Diagnostics;

    [TestClass]
    public class UnitTest1
    {      
        private static string fileContents = File.ReadAllText(@"request.xml");

        [TestMethod]
        public void TestMethod1()
        {
            //First Test
            XMLTopUpParser.ParseRequest(fileContents);
            //Check that the xml document isn't null 
            Debug.Assert(fileContents != null, "The xml parse file is null, re check the file data!");            
        }
    }
}

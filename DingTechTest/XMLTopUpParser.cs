using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DingTechTest
{

    public class XMLTopUpParser
    {

        private static byte[] requestBytes;
        private static string fileContents;
        private static string responseXML;


        static void Main(string[] args)
        {

	        Console.WriteLine("Enter start/exit:"); // Prompt
	        string line = Console.ReadLine(); // Get string from user
	        if (line == "exit") // Check string
	        {
                Environment.Exit(0);
	        }
            else
            {

                fileContents = File.ReadAllText(@"request.xml");
                ParseXML(fileContents);

                Console.WriteLine("Converting request to response object..");

                responseXML = System.Text.Encoding.UTF8.GetString(requestBytes);
            
            }
            
        }



        public static byte[] ParseXML(string xml)
        {

            try
            {
                requestBytes = System.Text.Encoding.UTF8.GetBytes(fileContents);
                Console.WriteLine("request parsing successful!");
                Console.WriteLine("...........................");
                Console.ReadKey(true);
                return (requestBytes);
                

            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: ", e);

            }
        }


    }
}

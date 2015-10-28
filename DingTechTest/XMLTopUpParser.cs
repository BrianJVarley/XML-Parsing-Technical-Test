namespace DingTechTest
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class XMLTopUpParser
    {
        private static byte[] requestBytes;
        private static string fileContents;
        private static string responseXML;

        static void Main(string[] args)
        {
            Console.Write("Enter 'Start' to begin parsing or 'Exit' to leave the program\r\n");
	        Console.WriteLine("Enter start/exit:");
	        string line = Console.ReadLine(); 
	        if (line == "exit") 
	        {
                Environment.Exit(0);
	        }
            else
            {
                fileContents = File.ReadAllText(@"request.xml");
                ParseRequest(fileContents);
                ParseResponse(requestBytes);   
            }     
        }

        private static string ParseResponse(byte[] bytes)
        {
            Console.WriteLine("Converting request to response object..");

            //Loop through byte array for API "Result Codes"
            // 99 = failure, 999 = Invalid message, 01 = success

            try
            {
                for(int i = 0; i < requestBytes.Length; i++)
                {
                    var v = requestBytes[i];
                    if (v == 99)
                    {
                        Console.WriteLine("Sending Failure..");
                    }
                    else if(v == 999) //noted that this check for the response 999 is void, as it's outside of the byte range.
                    {
                        Console.WriteLine("Message Failure..");
                    }
                    else if (v == 01)
                    {
                        Console.WriteLine("Sending Success..");
                    }

                }


                //Convert response to XML
                responseXML = System.Text.Encoding.UTF8.GetString(requestBytes);
                Console.WriteLine("Converting request successful..");
                Console.ReadKey(true);                


            }
            catch (Exception e)
            {
                Console.WriteLine("A response parsing error occurred!: ", e);
            }
            return responseXML;
        }


        public static byte[] ParseRequest(string xml)
        {
            try
            {
                ///Convert request to a byte array
                requestBytes = System.Text.Encoding.UTF8.GetBytes(fileContents);
                Console.WriteLine("Request parsing successful..");
                Console.WriteLine("...........................");
                Console.ReadKey(true);                
            }
            catch (Exception e)
            {
                Console.WriteLine("A request parsing error occurred!: ", e);
            }
            return (requestBytes);
        }
    }
}

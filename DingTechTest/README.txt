README - Ding Graduate .NET Developer – Technical Test Solutions

Developer - Brian J Varley

================================================================

*Part 1:

See console application, "XMLTopUpParser" and associtaed unit test project.

*Part 2:

Transaction response 1, shows four occurences of a failure code 99 in the response byte array.
Transaction response 2, shows four occurences of a failure code 99 in the response byte array.


*Part 3:

API integration questions - 

1.How active is the API's customer support service, and what level of support is offered?
2.How is the API's latency and uptime viewed?
3.Is there a .Net client library for the API?
4.How are API, errors logged and monitored?
5.Is there additional documentation on the API?
6.What other platforms has the API been integrated and developed for?
7.Are there any usage/traffic limits with the API?
8.How active is the API in daily usage, ie, how many calls are made to the API daily?

Conclusions/Notes:

#The parsing of a response, throws an error code 99 when looping through the byte array. 
Not sure if looping through the index values rather than the integer values associated 
with each index in byte array. Feedback appreciated.

#What text encoding format was expected for the sending side of the request data?

#Should I have feed the byte array from the original request byte array or the 
raw byte array from the technical test PDF?

#UnitTest passed as expected with sample XML data.

#The console app contains some `Console.ReadKey(true);` so just hit enter to keep 
stepping through the application.

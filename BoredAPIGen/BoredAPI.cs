using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text.Json;

namespace BoredAPIGen
{
    class BoredAPI
        {
            /*
             * FetchAPI method, takes in a list of string Options and an out string for an errorMessage
             * Utilizing the WebClient class, it makes a request to the Bored API server for a JSON Object of a random activity.
             */

            public static BoredResponse FetchAPI(List<string> Options, out string errorMessage)
            {
                WebClient client = new WebClient();

                using (client)
                {
                    // URL for making APIs requests to the BoredAPI service, this requests a selected activity.
                    string url = $"http://www.boredapi.com/api/activity/?type={Options[0]}&minprice=0&maxprice={Options[1]}&minaccessibility=0&maxaccessibility={Options[2]}";

                    try
                    {
                        // Make request, download JSON response as a string 
                        var responseString = client.DownloadString(url);

                    Debug.WriteLine(responseString);
                        // Configure JSON serializer
                        // use setting to convert JSON lowercase attributes to C# style CamelCase variables
                        var serializerOptions = new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                        };

                    // Deserialize - convert the JSON to a custom C# object of type BoredResponse. 
                    // The properties and values in the JSON are converted to properties and values in the C# object
                    // See also the BoredAPIResp.cs file 
                    BoredResponse response = JsonSerializer.Deserialize<BoredResponse>(responseString, serializerOptions);
                     
                        if (response.Error == "No activities found with the specified parameters") throw new Exception("No activities found with the specified parameters");

                        // Everything seems to have worked, set errorMessage to null 
                        // and return response containing all the Activity class.
                        errorMessage = null;
                        return response;

                    }
                    catch (WebException we)
                    {
                        // Catch various connectivity problems
                        errorMessage = "Error fetching data from API because:\n" + we.Message;
                    return null;
                    }
                    catch (Exception ex)
                    {
                        // For catching server returned errors and for other things that may go wrong.
                        errorMessage = "Unexpected Exception with message:\n" + ex.Message;
                    return null;
                    }
                }
            }
    }
}

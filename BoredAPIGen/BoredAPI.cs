using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text.Json;

namespace BoredAPIGen
{
    class BoredAPI
        {
            public static BoredResponse FetchAPI(out string errorMessage, List<string> Options)
            {
                WebClient client = new WebClient();

                using (client)
                {
                // URL for making APIs requests to the BoredAPI service, this requests a selected activity.
                    string url = $"http://www.boredapi.com/api/activity/?type={Options[0]}&minprice=0&maxprice={Options[1]}";

                    try
                    {

                        Debug.WriteLine("Using URL " + url);

                        // Make request, download JSON response as a string 
                        var responseString = client.DownloadString(url);

                    Debug.WriteLine(responseString);
                        // Configure JSON serializer
                        // use setting to convert JSON lowercase attributes to C# style CamelCase variables
                        var serializerOptions = new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                        };

                    // Deserialize - convert the JSON to a custom C# object of type APODResponse. 
                    // The properties and values in the JSON are converted to properties and values in the C# object
                    // See also the BoredAPIResp.cs file 
                    BoredResponse response = JsonSerializer.Deserialize<BoredResponse>(responseString, serializerOptions);


                        // For troubleshooting
                        Debug.WriteLine(response);

                        // Everything seems to have worked, set errorMessage to null 
                        // and return response containing all the APOD data
                        errorMessage = null;
                        return response;

                    }
                    catch (WebException we)
                    {
                        // Catch various connectivity problems
                        errorMessage = "Error fetching data from API because " + we.Message;
                    }
                    catch (Exception ex)
                    {
                        // And for other things that may go wrong. 
                        errorMessage = "Unexpected Exception with message " + ex.Message;
                    }

                    // For troubleshooting
                    Debug.WriteLine($"Error fetching data from API because {errorMessage}");

                    return null;   // Caller will be able to check for a null return value, to test if request was not succesful
                }
            }
    }
}

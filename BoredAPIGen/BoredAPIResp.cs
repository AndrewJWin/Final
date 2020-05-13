using System;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BoredAPIGen
{
	// Following JsonConverter provided by Clara James | 5/12/2020. - Much appreciated.
	class BoredResponseDecimalConverter : JsonConverter<Decimal>
	{
		public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
				try
				{
					decimal data = reader.GetDecimal();
					return data;
				}
				catch
				{
					return 0m;
				}
		}

		// Write method, unused - Should not be run in any extent.
		public override void Write(Utf8JsonWriter writer, Decimal value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();  
			// Unused as we're not building JSON Objects.
		}
	}
	class BoredResponse
    {
	/* 
	 * This class has properties that match the properties in a JSON response from the API. 
	 * When a response is made from the server, the JSON response is deserialized - converted into an BoredResponse C# object
	 * The data in each property in the BoredResponse comes from the matching JSON response property names. 
     */
		
		// The following property is set for catching errors and should remain null as long as valid input is recieved.
		public string Error { get; set; }

		// The following properties are basic properties set by the deserialized JSON input.
		public string Activity { get; set; }
		public string Type { get; set; }
		public string Link { get; set; }
		public string Key { get; set; }
		
		// The following utilizes the JsonConverter to ensure the value provided is a correct decimal value.

		[JsonConverter(typeof(BoredResponseDecimalConverter))]
		public decimal Price { get; set; }

		[JsonConverter(typeof(BoredResponseDecimalConverter))]
		public decimal Accessibility { get; set; }

		[JsonConverter(typeof(BoredResponseDecimalConverter))]
		public decimal Participants { get; set; }


		// showLink method, shows the webpage attached to this specific Activity.
		public void showLink()
		{
			// Validating if the link is blank - Though this should never occur as the link label should be disabled.
			if (Link != "")
			{
				// Uses Process to start the default browser to open the link.
				Process.Start(Link);
			}
		}

		// shortActivity method, reduces the overall length of the activity for use in a saved list.
		public string shortActivity()
		{
			int maxLength = 25;

			// The following line effectively substrings from the full length to the maximum length and adds elipses to the end.
			return Activity.Length <= maxLength ? Activity : Activity.Substring(0, maxLength) + "...";

		}
	}
}

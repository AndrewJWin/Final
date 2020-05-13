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

		public override void Write(Utf8JsonWriter writer, Decimal value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();  
			// Unused as we're not building JSON Objects.
		}
	}
	class BoredResponse
    {
	/* 
	 * This class has properties that match the properties in a JSON response from the APOD server. 
	 * When a response is made to APOD, the JSON response is deserialized - converted into an APODResponse C# object
	 * The data in each property in the APODResponse comes from the matching JSON response property names. 
     */
		
		public string Error { get; set; }
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

		// ShowWebPage Method, takes in a plantName for a requested plant information - Otherwise show the default homepage.
		public void showLink()
		{

			if (Link != "")
			{
				Debug.WriteLine(Link);
				// Uses the system Processes to start the default browser with the requested Webpage.
				Process.Start(Link);
			}
		}

		public string shortActivity()
		{
			int maxLength = 25;

			return Activity.Length <= maxLength ? Activity : Activity.Substring(0, maxLength) + "...";

		}
	}
}

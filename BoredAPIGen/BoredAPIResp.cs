using System;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BoredAPIGen
{

	class BoredPriceResponseConverter : JsonConverter<Decimal>
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
				return 0m; // or whatever default you'd like 
			}

		}

		public override void Write(Utf8JsonWriter writer, Decimal value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();  
			// You don't need this if you don't plan to create JSON from your C# objects
		}
	}
	class BoredResponse
    {
	/* 
	 * This class has properties that match the properties in a JSON response from the APOD server. 
	 * When a response is made to APOD, the JSON response is deserialized - converted into an APODResponse C# object
	 * The data in each property in the APODResponse comes from the matching JSON response property names. 
     */

		public string Activity { get; set; }
		public string Type { get; set; }

		[JsonConverter(typeof(BoredPriceResponseConverter))]
		public decimal Price { get; set; }
		public string Link { get; set; }
		public string Key { get; set; }

		public override string ToString()
		{
			return $"ACTIVITY: {Activity} \n" +
				$"TYPE: {Type} \n" +
				$"PRICE: {Price}\n" +
				$"LINK: {Link}" +
				$"KEY: {Key}";
		}
	}
}

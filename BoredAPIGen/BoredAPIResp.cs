using System;

namespace BoredAPIGen
{
    class BoredResponse
    {
	/* 
	 * This class has properties that match the properties in a JSON response from the APOD server. 
	 * When a response is made to APOD, the JSON response is deserialized - converted into an APODResponse C# object
	 * The data in each property in the APODResponse comes from the matching JSON response property names. 
     */

		public string Activity { get; set; }
		public string Type { get; set; }
		public float? Price { get; set; }
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

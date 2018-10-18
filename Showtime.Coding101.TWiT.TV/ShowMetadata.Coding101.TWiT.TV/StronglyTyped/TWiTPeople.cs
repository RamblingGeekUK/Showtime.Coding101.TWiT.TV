/*
	TWiT LLC	
	TWiT.TV API
	http://docs.twittv.apiary.io/
	
	Wrapper classes, or strongly typed, TWiT API entities like 'Shows', 'Episodes', etc...

	File generated from Paste JSON as Classes:
	https://channel9.msdn.com/Series/Windows-Store-Developer-Solutions/Quckly-Generate-C-Classes-from-JSON-Responses

	Follow-us @:
	http://twitter.com/LouMM
	http://twitter.com/PadreSJ

	Subscribe to our video casts:
	http://twit.tv/code
	https://www.youtube.com/user/TWiTCoding101
*/


namespace StudioMetadata.Coding101.TWiT.TV
{
	using Newtonsoft.Json;
	using System;
	using System.Collections.Generic;
	public class Person
	{
		[JsonProperty("id")]
		public int id { get; set; }
		[JsonProperty("label")]
		public string label { get; set; }
		[JsonProperty("cleanPath")]
		public string cleanPath { get; set; }
		[JsonProperty("ttl")]
		public string ttl { get; set; }
		[JsonProperty("positionTitle")]
		public string positionTitle { get; set; }
		[JsonProperty("bio")]
		public string bio { get; set; }
		[JsonProperty("bioSummary")]
		public string bioSummary { get; set; }
		[JsonProperty("picture")]
		public Picture picture { get; set; }
		[JsonProperty("relatedLinks")]
		public object relatedLinks { get; set; }
		[JsonProperty("published")]
		public string published { get; set; }
		[JsonProperty("created")]
		public DateTime created { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("sticky")]
		public string sticky { get; set; }
		[JsonProperty("staff")]
		public bool staff { get; set; }
		[JsonProperty("_links")]
		public Links _links { get; set; }
	}
	public class People
	{
		[JsonProperty("count")]
		public int count { get; set; }
		[JsonProperty("people")]
		public IList<Person> people { get; set; }
		[JsonProperty("_links")]
		public Links _links { get; set; }
	}
}
/*
	Footer
	
	TWiT LLC	
	
	Permission is hereby granted, free of charge, to any person obtaining a copy
	of this software and associated documentation files (the "Software"), to deal
	in the Software without restriction, including without limitation the rights
	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
	copies of the Software, and to permit persons to whom the Software is
	furnished to do so, subject to the following conditions:

	The above copyright notice and this permission notice shall be included in
	all copies or substantial portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
	SOFTWARE.


*/

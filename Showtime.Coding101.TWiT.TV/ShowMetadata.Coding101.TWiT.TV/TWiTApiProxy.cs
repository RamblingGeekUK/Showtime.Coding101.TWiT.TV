/*
	[Comments]

	TWiT LLC	
	TWiT.TV API
	http://docs.twittv.apiary.io/
	
	Proxy code is a wrapper around the TWiT REST API that will return a entity type like 'Shows' or 'Episodes' 

	Follow-us @:
	http://twitter.com/LouMM
	http://twitter.com/PadreSJ

	Subscribe to our video casts:
	http://twit.tv/code
	https://www.youtube.com/user/TWiTCoding101
*/

namespace StudioMetadata.Coding101.TWiT.TV
{
	using System;
	using System.Globalization;
	using System.Net.Http;
	using System.Threading.Tasks;

	public class TWiTApiProxy
	{
		public static async Task<string> TWiTRestRequest(string method, string parameters = null)
		{
			Uri baseAddress;
#if DEBUG
			//baseAddress = new Uri("http://private-202b1c-twittv.apiary-mock.com/api/v1.0/");
			baseAddress = new Uri("https://twit.tv/api/v1.0/"); //Base Address plus Path to the API
#else
            baseAddress = new Uri("https://twit.tv/api/v1.0/"); //Base Address plus Path to the API
#endif

			/*
			*	HttpClient class is used to send and receive basic requests over HTTP. It provides a base class for 
			*	sending HTTP requests and receiving HTTP responses from a resource identified by a URI. This class 
			*	can be used to send a GET, PUT, POST, DELETE, and other requests to a web service. Each of these 
			*	requests is sent as an asynchronous operation. 
			*/
			using (var httpClient = new HttpClient() { BaseAddress = baseAddress }) //HTTP client components that allow users to consume modern web services over HTTP
			{
				httpClient.DefaultRequestHeaders.Clear();
				httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
				httpClient.DefaultRequestHeaders.Add("app-id", "[REPLACE WITH YOUR APP-ID"); 
				httpClient.DefaultRequestHeaders.Add("app-key", "[REPLACE WITH YOUR APP-KEY]"); 

				string showsUrl = String.Format( //apply formatting (and add surrounding text). We specify substitution markers (e.g. {0}{1}). Many methods (string.Format, Console.WriteLine, ToString, AppendFormat) use format syntax.
													CultureInfo.InvariantCulture,	//Provides information about a specific culture (called a locale for unmanaged code development). The information includes the names for the culture, the writing system, the calendar used, the sort order of strings, and formatting for dates and numbers. 
													"{0}{1}",						//Format the Query String using these substitution markers
													method,							//Method to call (e.g. Shows, Episodes, etc..)
													parameters == null ? string.Empty : parameters    //Additional Parameters (e.g. Filters[shows]) 
												);

				try
				{
					using (var response = await httpClient.GetAsync(showsUrl)) //TODO: Change to Stream for large return values (e.g. Every show on TWiT)
					{
						if (response.IsSuccessStatusCode) //Status Code 200 or 304 NotModified which is if The client's cached copy is up to date. The contents of the resource are not transferred.
						{
							string responseData = await response.Content.ReadAsStringAsync();
							return responseData; //TODO: once stream is return, changed this to returning a stream.
												 /*
												 * In .NET, any object larger than 85KB is automatically assigned to the Large Object Heap. 
												 * Objects in the LOH require the Garbage Collector to suspend all threads in order to clean them up, which has major 
												 * implications from a performance perspective. If the returned feed is reasonably large, and you cache it in a string, 
												 * you’ll potentially introduce significant overhead in your app. Caching to an IO.Stream avoids this issue, 
												 * because the feed will be chunked and read in smaller portions as you parse it.
												 */
						}
						else //Failure code from HTTP, handle the issue and throw an exception: https://msdn.microsoft.com/en-us/library/windows/apps/windows.web.http.httpstatuscode
						{
							HandleIssue(response);
						}
					}
				}
				catch(Exception ex)
				{
					throw new TWiTApiException(ex.Message,ex.InnerException);					
					//TODO: Added explicit exception handling 
				}
			}
			return null;
		}
		private static void HandleIssue(HttpResponseMessage response)
		{
			switch(response.StatusCode)
			{
				case System.Net.HttpStatusCode.InternalServerError:
					throw new TWiTApiException("Either your API Key and App-ID have not been registered, or you forgot to go and register one, or you have been throttled. :)");				
				default:
					throw new TWiTApiException(string.Format(CultureInfo.InvariantCulture,"Failed with Status Code {0} and Reason {1}", response.StatusCode.ToString(), response.ReasonPhrase));
			}
			
				

		}
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

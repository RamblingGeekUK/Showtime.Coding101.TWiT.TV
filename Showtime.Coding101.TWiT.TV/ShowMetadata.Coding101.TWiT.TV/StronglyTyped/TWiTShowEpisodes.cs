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
	using System.Runtime.Serialization;
	public class VideoHd
	{
		[JsonProperty("mediaUrl")]
		public string mediaUrl { get; set; }
		[JsonProperty("format")]
		public string format { get; set; }
		[JsonProperty("guid")]
		public object guid { get; set; }
		[JsonProperty("size")]
		public object size { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("runningTime")]
		public string runningTime { get; set; }
		[JsonProperty("hours")]
		public string hours { get; set; }
		[JsonProperty("minutes")]
		public string minutes { get; set; }
		[JsonProperty("seconds")]
		public string seconds { get; set; }
	}

	public class VideoLarge
	{
		[JsonProperty("mediaUrl")]
		public string mediaUrl { get; set; }
		[JsonProperty("format")]
		public string format { get; set; }
		[JsonProperty("guid")]
		public object guid { get; set; }
		[JsonProperty("size")]
		public object size { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("runningTime")]
		public string runningTime { get; set; }
		[JsonProperty("hours")]
		public string hours { get; set; }
		[JsonProperty("minutes")]
		public string minutes { get; set; }
		[JsonProperty("seconds")]
		public string seconds { get; set; }
	}

	public class VideoSmall
	{
		[JsonProperty("mediaUrl")]
		public string mediaUrl { get; set; }
		[JsonProperty("format")]
		public string format { get; set; }
		[JsonProperty("guid")]
		public object guid { get; set; }
		[JsonProperty("size")]
		public object size { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("runningTime")]
		public string runningTime { get; set; }
		[JsonProperty("hours")]
		public string hours { get; set; }
		[JsonProperty("minutes")]
		public string minutes { get; set; }
		[JsonProperty("seconds")]
		public string seconds { get; set; }
	}

	public class VideoAudio
	{
		[JsonProperty("mediaUrl")]
		public string mediaUrl { get; set; }
		[JsonProperty("format")]
		public string format { get; set; }
		[JsonProperty("guid")]
		public object guid { get; set; }
		[JsonProperty("size")]
		public object size { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("runningTime")]
		public string runningTime { get; set; }
		[JsonProperty("hours")]
		public string hours { get; set; }
		[JsonProperty("minutes")]
		public string minutes { get; set; }
		[JsonProperty("seconds")]
		public string seconds { get; set; }
	}

	public class Episode
	{
		[JsonProperty("id")]
		public int id { get; set; }
		[JsonProperty("label")]
		public string Title { get; set; }
		[JsonProperty("cleanPath")]
		public string cleanPath { get; set; }
		[JsonProperty("ttl")]
		public string ttl { get; set; }
		[JsonProperty("topics")]
		public object topics { get; set; }
		[JsonProperty("episodeNumber")]
		public string episodeNumber { get; set; }
		[JsonProperty("airingDate")]
		public DateTime AiringDate { get; set; }
		[JsonProperty("teaser")]
		public string teaser { get; set; }
		[JsonProperty("showNotes")]
		public string showNotes { get; set; }
		[JsonProperty("showNotesFooter")]
		public object showNotesFooter { get; set; }
		[JsonProperty("relatedLinks")]
		public object relatedLinks { get; set; }
		[JsonProperty("files")]
		public object files { get; set; }
		[JsonProperty("heroImage")]
		public HeroImage heroImage { get; set; }
		[JsonProperty("video_hd")]
		public VideoHd video_hd { get; set; }
		[JsonProperty("video_large")]
		public VideoLarge video_large { get; set; }
		[JsonProperty("video_small")]
		public VideoSmall video_small { get; set; }
		[JsonProperty("video_audio")]
		public VideoAudio video_audio { get; set; }
		[JsonProperty("video_youtube")]
		public object video_youtube { get; set; }
		[JsonProperty("published")]
		public string published { get; set; }
		[JsonProperty("created")]
		public DateTime created { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("_links")]
		public Links _links { get; set; }
		[JsonProperty("_embedded")]
		public EmbeddedData _embedded { get; set; }
	}

	public class TWiTShowEpisodes
	{
		[JsonProperty("count")]
		public int count { get; set; }
		[JsonProperty("episodes")]
		public IList<Episode> episodes { get; set; }

		[JsonProperty("_embedded")]
		public IList<object> _embedded { get; set; }

		[JsonProperty("_links"), DataMember(Name = "_links")]
		public Links Links { get; set; }
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

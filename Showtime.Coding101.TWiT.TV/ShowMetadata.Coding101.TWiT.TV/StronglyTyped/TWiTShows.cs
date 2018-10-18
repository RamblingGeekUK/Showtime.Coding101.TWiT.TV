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
	public class TWiTShows
	{
		/// <summary>
		/// The amount of shows returned
		/// </summary>
		[JsonProperty("count"), DataMember(Name = "count")]
		public int Count { get; set; }

		/// <summary>
		/// Collection of Shows
		/// </summary>
		[JsonProperty("shows"), DataMember(Name = "shows")]
		public IList<Show> Shows { get; set; }

		[JsonProperty("_embedded")]
		public IList<object> _embedded { get; set; }

		[JsonProperty("_links"), DataMember(Name = "_links")]
		public Links Links { get; set; }
	}

	public class FeedProvider
	{
		[JsonProperty("id")]
		public string id { get; set; }
		[JsonProperty("label")]
		public string label { get; set; }
		[JsonProperty("self")]
		public string self { get; set; }
		[JsonProperty("ttl")]
		public string ttl { get; set; }
		[JsonProperty("active")]
		public bool active { get; set; }
		[JsonProperty("created")]
		public DateTime created { get; set; }
	}

	public class ViewSubscriptionOption
	{
		[JsonProperty("id")]
		public string id { get; set; }
		[JsonProperty("label")]
		public string label { get; set; }
		[JsonProperty("self")]
		public string self { get; set; }
		[JsonProperty("ttl")]
		public string ttl { get; set; }
		[JsonProperty("feedProvider")]
		public FeedProvider feedProvider { get; set; }
		[JsonProperty("url")]
		public string url { get; set; }
		[JsonProperty("type")]
		public string type { get; set; }
		[JsonProperty("created")]
		public DateTime created { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("sticky")]
		public string sticky { get; set; }
	}

	public class HdVideoSubscriptionOption : ViewSubscriptionOption
	{
	}

	public class SdVideoLargeSubscriptionOption : ViewSubscriptionOption
	{
	}

	public class SdVideoSmallSubscriptionOption : ViewSubscriptionOption
	{
	}

	public class AudioSubscriptionOption
	{
		[JsonProperty("id")]
		public string id { get; set; }
		[JsonProperty("label")]
		public string label { get; set; }
		[JsonProperty("self")]
		public string self { get; set; }
		[JsonProperty("ttl")]
		public string ttl { get; set; }
		[JsonProperty("feedProvider")]
		public FeedProvider feedProvider { get; set; }
		[JsonProperty("url")]
		public string url { get; set; }
		[JsonProperty("type")]
		public string type { get; set; }
		[JsonProperty("created")]
		public DateTime created { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("sticky")]
		public string sticky { get; set; }
	}
	[JsonObject("Derivatives")]
	public class SlideShowImageDerivatives
	{
		[JsonProperty("thumbnail")]
		public string thumbnail { get; set; }
		[JsonProperty("twit_slideshow_1600x400")]
		public string twit_slideshow_1600x400 { get; set; }
		[JsonProperty("twit_slideshow_1200x300")]
		public string twit_slideshow_1200x300 { get; set; }
		[JsonProperty("twit_slideshow_800x200")]
		public string twit_slideshow_800x200 { get; set; }
		[JsonProperty("twit_slideshow_600x450")]
		public string twit_slideshow_600x450 { get; set; }
		[JsonProperty("twit_slideshow_400x300")]
		public string twit_slideshow_400x300 { get; set; }
	}

	public class HeroImage
	{
		[JsonProperty("fid")]
		public string fid { get; set; }
		[JsonProperty("url")]
		public string url { get; set; }
		[JsonProperty("fileName")]
		public string fileName { get; set; }
		[JsonProperty("mimeType")]
		public string mimeType { get; set; }
		[JsonProperty("derivatives")]
		public SlideShowImageDerivatives derivatives { get; set; }
		[JsonProperty("fileSize")]
		public string fileSize { get; set; }
		[JsonProperty("width")]
		public string width { get; set; }
		[JsonProperty("height")]
		public string height { get; set; }
		[JsonProperty("alt")]
		public string alt { get; set; }
		[JsonProperty("title")]
		public string title { get; set; }
		[JsonProperty("status")]
		public string status { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("created")]
		public DateTime created { get; set; }
	}

	[JsonObject("derivatives")]
	public class AlbumArtDerivatives
	{
		[JsonProperty("thumbnail")]
		public string thumbnail { get; set; }
		[JsonProperty("twit_album_art_70x70")]
		public string twit_album_art_70x70 { get; set; }
		[JsonProperty("twit_album_art_144x144")]
		public string twit_album_art_144x144 { get; set; }
		[JsonProperty("twit_album_art_240x240")]
		public string twit_album_art_240x240 { get; set; }
		[JsonProperty("twit_album_art_300x300")]
		public string twit_album_art_300x300 { get; set; }
		[JsonProperty("twit_album_art_600x600")]
		public string twit_album_art_600x600 { get; set; }
		[JsonProperty("twit_album_art_1400x1400")]
		public string twit_album_art_1400x1400 { get; set; }
		[JsonProperty("twit_album_art_2048x2048")]
		public string twit_album_art_2048x2048 { get; set; }
	}

	public class CoverArt
	{
		[JsonProperty("fid")]
		public string fid { get; set; }
		[JsonProperty("url")]
		public Uri url { get; set; }
		[JsonProperty("fileName")]
		public string fileName { get; set; }
		[JsonProperty("mimeType")]
		public string mimeType { get; set; }
		[JsonProperty("derivatives")]
		public AlbumArtDerivatives derivatives { get; set; }
		[JsonProperty("fileSize")]
		public string fileSize { get; set; }
		[JsonProperty("width")]
		public string width { get; set; }
		[JsonProperty("height")]
		public string height { get; set; }
		[JsonProperty("alt")]
		public string alt { get; set; }
		[JsonProperty("title")]
		public string title { get; set; }
		[JsonProperty("status")]
		public string status { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("created")]
		public DateTime created { get; set; }
	}

	public class Self
	{
		[JsonProperty("title"), DataMember(Name = "title")]
		public string Title { get; set; }

		[JsonProperty("href"), DataMember(Name = "href")]
		public Uri Href { get; set; }
	}

	public class Links
	{
		[JsonProperty("self")]
		public Self self { get; set; }

		[JsonProperty("episodes")]
		public Episodes episodes { get; set; }

		[JsonProperty("next")]
		public Next next { get; set; }
	}

	public class Roles
	{
		[JsonProperty("id")]
		public string id { get; set; }
		[JsonProperty("label")]
		public string label { get; set; }
		[JsonProperty("self")]
		public string self { get; set; }
		[JsonProperty("ttl")]
		public string ttl { get; set; }
		[JsonProperty("weight")]
		public string weight { get; set; }
		[JsonProperty("vid")]
		public string vid { get; set; }
		[JsonProperty("type")]
		public string type { get; set; }
		[JsonProperty("vocabularyName")]
		public string vocabularyName { get; set; }
		[JsonProperty("termPath")]
		public string termPath { get; set; }
	}


	public class Picture
	{
		[JsonProperty("fid")]
		public string fid { get; set; }
		[JsonProperty("url")]
		public string url { get; set; }
		[JsonProperty("fileName")]
		public string fileName { get; set; }
		[JsonProperty("mimeType")]
		public string mimeType { get; set; }
		[JsonProperty("derivatives")]
		public AlbumArtDerivatives derivatives { get; set; }
		[JsonProperty("fileSize")]
		public string fileSize { get; set; }
		[JsonProperty("width")]
		public string width { get; set; }
		[JsonProperty("height")]
		public string height { get; set; }
		[JsonProperty("alt")]
		public string alt { get; set; }
		[JsonProperty("title")]
		public string title { get; set; }
		[JsonProperty("status")]
		public string status { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("created")]
		public DateTime created { get; set; }
	}

	public class RelatedLink
	{
		[JsonProperty("url")]
		public string url { get; set; }
		[JsonProperty("title")]
		public string title { get; set; }
		[JsonProperty("attributes")]
		public IList<object> attributes { get; set; }
	}

	[JsonObject("People")]
	public class ShowPeople : Person
	{ }

	public class Credit
	{
		[JsonProperty("id")]
		public string id { get; set; }
		[JsonProperty("label")]
		public string label { get; set; }
		[JsonProperty("ttl")]
		public string ttl { get; set; }
		[JsonProperty("roles")]
		public Roles roles { get; set; }
		[JsonProperty("people")]
		public ShowPeople people { get; set; }
		[JsonProperty("created")]
		public DateTime created { get; set; }
		[JsonProperty("_links")]
		public Links _links { get; set; }
	}

	public class Topic
	{
		[JsonProperty("id")]
		public string id { get; set; }
		[JsonProperty("label")]
		public string label { get; set; }
		[JsonProperty("ttl")]
		public string ttl { get; set; }
		[JsonProperty("weight")]
		public string weight { get; set; }
		[JsonProperty("vid")]
		public string vid { get; set; }
		[JsonProperty("type")]
		public string type { get; set; }
		[JsonProperty("vocabularyName")]
		public string vocabularyName { get; set; }
		[JsonProperty("termPath")]
		public string termPath { get; set; }
		[JsonProperty("_links")]
		public Links _links { get; set; }
	}

	public class Category
	{
		[JsonProperty("id")]
		public string id { get; set; }
		[JsonProperty("label")]
		public string label { get; set; }
		[JsonProperty("ttl")]
		public string ttl { get; set; }
		[JsonProperty("weight")]
		public string weight { get; set; }
		[JsonProperty("vid")]
		public string vid { get; set; }
		[JsonProperty("type")]
		public string type { get; set; }
		[JsonProperty("vocabularyName")]
		public string vocabularyName { get; set; }
		[JsonProperty("termPath")]
		public string termPath { get; set; }
		[JsonProperty("_links")]
		public Links _links { get; set; }
	}

	public class Show
	{
		public override bool Equals(object obj)
		{
			var p1 = (Show)obj;
			return this.Id == p1.Id;
		}

		[JsonProperty("id"), DataMember(Name = "id")]
		public int Id { get; set; }

		[JsonProperty("label"), DataMember(Name = "label")]
		public string Title { get; set; }

		[JsonProperty("cleanPath"), DataMember(Name = "cleanPath")]
		public Uri RelativePath { get; set; }

		[JsonProperty("ttl"), DataMember(Name = "ttl")]
		public string Ttl { get; set; }

		[JsonProperty("description"), DataMember(Name = "description")]
		public string Description { get; set; }

		[JsonProperty("descriptionSummary"), DataMember(Name = "descriptionSummary")]
		public string DescriptionSummary { get; set; }

		[JsonProperty("showNotes"), DataMember(Name = "showNotes")]
		public object ShowNotes { get; set; }

		[JsonProperty("showDate"), DataMember(Name = "showDate")]
		public string ShowDate { get; set; }

		[JsonProperty("showContactInfo"), DataMember(Name = "showContactInfo")]
		public string ShowContactInfo { get; set; }

		[JsonProperty("tagLine"), DataMember(Name = "tagLine")]
		public string TagLine { get; set; }

		[JsonProperty("shortCode"), DataMember(Name = "shortCode")]
		public string ShortCode { get; set; }

		[JsonProperty("hdVideoSubscriptionOptions"), DataMember(Name = "hdVideoSubscriptionOptions")]
		public IList<HdVideoSubscriptionOption> HdVideoSubscriptionOptions { get; set; }

		[JsonProperty("sdVideoLargeSubscriptionOptions"), DataMember(Name = "sdVideoLargeSubscriptionOptions")]
		public IList<SdVideoLargeSubscriptionOption> SdVideoLargeSubscriptionOptions { get; set; }

		[JsonProperty("sdVideoSmallSubscriptionOptions"), DataMember(Name = "sdVideoSmallSubscriptionOptions")]
		public IList<SdVideoSmallSubscriptionOption> SdVideoSmallSubscriptionOptions { get; set; }

		[JsonProperty("audioSubscriptionOptions"), DataMember(Name = "audioSubscriptionOptions")]
		public IList<AudioSubscriptionOption> AudioSubscriptionOptions { get; set; }

		[JsonProperty("heroImage"), DataMember(Name = "heroImage")]
		public HeroImage HeroImage { get; set; }

		[JsonProperty("coverArt"), DataMember(Name = "coverArt")]
		public CoverArt CoverArt { get; set; }

		[JsonProperty("active"), DataMember(Name = "active")]
		public bool Active { get; set; }

		[JsonProperty("created"), DataMember(Name = "created")]
		public DateTime Created { get; set; }

		[JsonProperty("weight"), DataMember(Name = "weight")]
		public string Weight { get; set; }

		[JsonProperty("_links"), DataMember(Name = "_links")]
		public Links Links { get; set; }

		[JsonProperty("_embedded"), DataMember(Name = "_embedded")]
		public EmbeddedData Embedded { get; set; }
	}

	[JsonObject("Embedded"), DataContract(Name = "Embedded")]
	public class EmbeddedData
	{
		[JsonProperty("credits")]
		public IList<Credit> credits { get; set; }
		[JsonProperty("shows")]
		public IList<Show> shows { get; set; }
		[JsonProperty("offers")]
		public IList<Offer> offers { get; set; }
		[JsonProperty("categories")]
		public IList<Category> categories { get; set; }
	}
	public class Offer
	{
		[JsonProperty("id")]
		public string id { get; set; }
		[JsonProperty("label")]
		public string label { get; set; }
		[JsonProperty("ttl")]
		public string ttl { get; set; }
		[JsonProperty("body")]
		public object body { get; set; }
		[JsonProperty("offerLink")]
		public OfferLink offerLink { get; set; }
		[JsonProperty("offerSponsor")]
		public OfferSponsor offerSponsor { get; set; }
		[JsonProperty("published")]
		public string published { get; set; }
		[JsonProperty("created")]
		public DateTime created { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("_links")]
		public Links _links { get; set; }
	}
	public class OfferLink
	{
		[JsonProperty("url")]
		public Uri Url { get; set; }
		[JsonProperty("title")]
		public string Title { get; set; }
		[JsonProperty("attributes")]
		public IList<object> Attributes { get; set; }
	}
	public class OfferSponsor
	{
		[JsonProperty("id")]
		public string id { get; set; }
		[JsonProperty("label")]
		public string label { get; set; }
		[JsonProperty("self")]
		public string self { get; set; }
		[JsonProperty("ttl")]
		public string ttl { get; set; }
		[JsonProperty("body")]
		public string body { get; set; }
		[JsonProperty("sponsorLogo")]
		public SponsorLogo sponsorLogo { get; set; }
		[JsonProperty("sponsorWebsite")]
		public SponsorWebsite sponsorWebsite { get; set; }
		[JsonProperty("published")]
		public string published { get; set; }
		[JsonProperty("created")]
		public DateTime created { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("sticky")]
		public string sticky { get; set; }
	}
	public class SponsorLogo
	{
		[JsonProperty("fid")]
		public string fid { get; set; }
		[JsonProperty("url")]
		public string url { get; set; }
		[JsonProperty("fileName")]
		public string fileName { get; set; }
		[JsonProperty("mimeType")]
		public string mimeType { get; set; }
		[JsonProperty("derivatives")]
		public SlideShowImageDerivatives derivatives { get; set; }
		[JsonProperty("fileSize")]
		public string fileSize { get; set; }
		[JsonProperty("width")]
		public string width { get; set; }
		[JsonProperty("height")]
		public string height { get; set; }
		[JsonProperty("alt")]
		public string alt { get; set; }
		[JsonProperty("title")]
		public string title { get; set; }
		[JsonProperty("status")]
		public string status { get; set; }
		[JsonProperty("changed")]
		public DateTime changed { get; set; }
		[JsonProperty("created")]
		public DateTime created { get; set; }
	}
	public class SponsorWebsite
	{
		[JsonProperty("url")]
		public string url { get; set; }
		[JsonProperty("title")]
		public string title { get; set; }
		[JsonProperty("attributes")]
		public IList<object> attributes { get; set; }
	}
	public class Episodes
	{
		[JsonProperty("title"), DataMember(Name = "title")]
		public string Title { get; set; }

		[JsonProperty("href"), DataMember(Name = "href")]
		public Uri Url { get; set; }
	}

	[JsonObject("Next"), DataContract(Name = "Next")]
	public class Next
	{
		[JsonProperty("title"), DataMember(Name = "title")]
		public string Title { get; set; }

		[JsonProperty("href"), DataMember(Name = "href")]
		public Uri Url { get; set; }
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

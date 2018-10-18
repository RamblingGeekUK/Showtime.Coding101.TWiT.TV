namespace Showtime.Coding101.TWiT.TV
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Globalization;
	using System.Windows.Input;
	class MainViewModel : INotifyPropertyChanged
	{
		#region Boiler-Plate Code for MVVM binding
		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
		protected bool SetField<T>(ref T field, T value, string propertyName)
		{
			if (EqualityComparer<T>.Default.Equals(field, value)) return false;
			field = value;
			OnPropertyChanged(propertyName);
			return true;
		}

		public ICommand RequestButtonCommand
		{
			get { return new DelegateCommand(ButtonClicked, CanButtonBeClicked); }
		}
		#endregion

		private string _title;
		public string ShowTitle
		{
			get { return _title; }
			set { SetField(ref _title, value, "ShowTitle"); }
		}

		/// <summary>
		/// Collection used to populate a Stack panel or list of the episodes of a show on the main UI.
		/// </summary>
		public ObservableCollection<StudioMetadata.Coding101.TWiT.TV.Episode> Episodes = new ObservableCollection<StudioMetadata.Coding101.TWiT.TV.Episode>();

		/// <summary>
		/// Button Click method that is executed when the Request Button is clicked on the main UI
		/// </summary>
		/// <param name="context">There is none for this button</param>
		private async void ButtonClicked(object context)
		{
			//Return Show Details
			var escapedShowName = Uri.EscapeUriString("Coding 101");
			string jsonShowResponse = null;
			try {
				jsonShowResponse = await StudioMetadata.Coding101.TWiT.TV.TWiTApiProxy.TWiTRestRequest("shows", string.Format(CultureInfo.InvariantCulture, "?filter[label]={0}", escapedShowName));
				var twitShows = Newtonsoft.Json.JsonConvert.DeserializeObject<StudioMetadata.Coding101.TWiT.TV.TWiTShows>(jsonShowResponse);
				jsonShowResponse = null; //Large (could be over 85K), null it out for the current stack.

				//Return All Episodes
				int numberOfEpisodes = 0;
				int returnedEpisodes = 0;
				Uri nextPageOfEpisodesUri = null;

				if (twitShows.Count > 0)
				{
					int showId = twitShows.Shows[0].Id;
					ShowTitle = twitShows.Shows[0].Title;
					while (returnedEpisodes == 0 || returnedEpisodes < numberOfEpisodes)
					{
						string jsonEpisodesResponse =
							await StudioMetadata.Coding101.TWiT.TV.TWiTApiProxy.TWiTRestRequest("episodes",
									null == nextPageOfEpisodesUri ?
									string.Format(CultureInfo.InvariantCulture, "?filter[shows]={0}", showId)
									:
									nextPageOfEpisodesUri.Query
								);

						var twitEpisodes = Newtonsoft.Json.JsonConvert.DeserializeObject<StudioMetadata.Coding101.TWiT.TV.TWiTShowEpisodes>(jsonEpisodesResponse);
						if (numberOfEpisodes == 0)
							numberOfEpisodes = twitEpisodes.count;

						if (numberOfEpisodes == 0)
							break;

						returnedEpisodes += twitEpisodes.episodes.Count;
						foreach (var episode in twitEpisodes.episodes)
							Episodes.Add(episode);
						if (returnedEpisodes < numberOfEpisodes)
						{
							if (twitEpisodes.Links.next.Url == null)
								break;

							nextPageOfEpisodesUri = twitEpisodes.Links.next.Url;
						}
					}
				}
			}
			catch(StudioMetadata.Coding101.TWiT.TV.TWiTApiException ex)
			{
				var dialog = new Windows.UI.Popups.MessageDialog(ex.Message);
				await dialog.ShowAsync();
			}
		}
		private bool CanButtonBeClicked(object context)
		{
			//this is called to evaluate whether FuncToCall can be called
			//for example you can return true or false based on some validation logic
			return true;
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

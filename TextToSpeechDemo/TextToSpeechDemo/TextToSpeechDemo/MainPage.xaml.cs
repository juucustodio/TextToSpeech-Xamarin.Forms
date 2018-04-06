using System;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace TextToSpeechDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}


	    public async void ButtonClick(object sender, EventArgs e)
	    {
            if (!String.IsNullOrWhiteSpace(Texto.Text))
	            await CrossTextToSpeech.Current.Speak(Texto.Text);
	    }
	}
}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Collections.Generic;

namespace MauiApp12
{
    public partial class MainPage : ContentPage
    {
        private Dictionary<Aspect, Aspect> _aspectCycle;

        public MainPage()
        {
            InitializeComponent();

            RemoteImage.Source = new UriImageSource
            {
                Uri = new Uri("https://preview.redd.it/why-is-larry-so-evil-v0-ty3qlu4swjle1.jpeg?auto=webp&s=41fc3ee5bcec63e5cb4cc69757a812fb80143f47"),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(7)
            };

            GifImage.Source = new UriImageSource
            {
                Uri = new Uri("https://media4.giphy.com/media/v1.Y2lkPTZjMDliOTUycDB4MXZiOGJ2MXg0bG9tNmM5ZzI0cjVmZzFkbjBzbnZ5Z255bHl5YSZlcD12MV9naWZzX3NlYXJjaCZjdT1n/YLPOIP1jPu1N87yemm/giphy.gif")
            };

            
            ButtonImage.Source = new UriImageSource
            {
                Uri = new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYEoeyh3np_6242WbcbBwdfFVvD9zQQO-2Rg&s")
            };

            _aspectCycle = new Dictionary<Aspect, Aspect>
            {
                { Aspect.AspectFit, Aspect.AspectFill },
                { Aspect.AspectFill, Aspect.Fill },
                { Aspect.Fill, Aspect.AspectFit }
            };
        }

        private void OnChangeAspectClicked(object sender, EventArgs e)
        {
            LocalImage.Aspect = _aspectCycle[LocalImage.Aspect];
            AspectLabel.Text = $"Aspect: {LocalImage.Aspect}";
        }
    }
}
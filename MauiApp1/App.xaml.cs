namespace MauiApp1;
using Microsoft.AspNetCore.Components.WebView.Maui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //MainPage = new MainPage();
        MainPage = new BlazorPage();
    }

    public class BlazorPage : ContentPage
    {
        public BlazorPage()
        {
            SetDynamicResource(BackgroundColorProperty, "SecondaryColor");

            var blazor = new BlazorWebView
            {
                HostPage = "wwwroot/index.html"
            };

            blazor.RootComponents.Add(new RootComponent
            {
                ComponentType = typeof(Main),
                Selector = "#app"
            });

            Content = blazor;
        }
    }
}

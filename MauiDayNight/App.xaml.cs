using MauiDayNight.Core;

namespace MauiDayNight
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            //this.Resources.MergedDictionaries.Add(new MauiDayNightCore.Resources.Raw.TelerikPatch());
            //_ = new TelerikPatch();
            _ = new CoreObject();
        }
    }
}

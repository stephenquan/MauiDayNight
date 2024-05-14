namespace MauiDayNight;

public partial class MainPage : ContentPage
{
    public AppTheme CurrentTheme
    {
        get => Application.Current.RequestedTheme;
        set
        {
            Application.Current.UserAppTheme = value;
            OnPropertyChanged(nameof(CurrentTheme));
        }
    }

    public MainPage()
    {
        InitializeComponent();
    }

    private void ToggleThemeButton_Clicked(object sender, EventArgs e)
    {
        CurrentTheme = CurrentTheme != AppTheme.Dark ? AppTheme.Dark : AppTheme.Light;
    }
}

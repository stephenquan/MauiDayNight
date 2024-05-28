namespace MauiDayNight;

public partial class MainPage : ContentPage
{
    public AppThemeManager AppThemeManager {get; }

    public MainPage(AppThemeManager appThemeManager)
    {
        AppThemeManager = appThemeManager;
        InitializeComponent();
        OnPropertyChanged(nameof(AppThemeManager));
    }

    private void ToggleThemeButton_Clicked(object sender, EventArgs e)
    {
        AppThemeManager.CurrentTheme = AppThemeManager.CurrentTheme != AppTheme.Dark ? AppTheme.Dark : AppTheme.Light;
    }
}

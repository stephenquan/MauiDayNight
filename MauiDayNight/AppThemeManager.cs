using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiDayNight;

public class AppThemeManager : ObservableObject
{
    public AppTheme CurrentTheme
    {
        get => Application.Current.UserAppTheme;
        set
        {
            Application.Current.UserAppTheme = value;
            OnPropertyChanged(nameof(CurrentTheme));
        }
    }
}

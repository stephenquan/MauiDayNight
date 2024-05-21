using Telerik.Maui.Controls.Compatibility;

namespace MauiDayNight.Core;

public static class CoreExtensions
{
    public static MauiAppBuilder UseDayNightCore(this MauiAppBuilder builder)
    {
        builder.UseTelerik();
        return builder;
    }
}

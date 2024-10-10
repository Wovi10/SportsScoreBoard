using MudBlazor;

namespace SportsScoreBoard.Models;

public static class MyMudThemeProvider
{
    public static MudTheme MyCustomTheme => new()
        {
            LayoutProperties = new LayoutProperties
            {
                DefaultBorderRadius = "5px",
                AppbarHeight = "80px"
            },
            PaletteDark = new PaletteDark
            {
                ActionDefault = "#45B6EE",
                AppbarBackground = Colors.Blue.Darken4,
                DrawerBackground = Colors.Gray.Darken4,
                Dark = Colors.Shades.White,
                Divider = "#303030",
                Error = "#EE6352",
                ErrorDarken = "#EE4E40",
                ErrorLighten = "#FF958A",
                GrayDark = "#737373",
                Primary = "#45B6EE",
                Secondary = "#1E5973",
                SecondaryContrastText = "#DAF0FC",
                Success = "#6A9E4D",
                SuccessDarken = "#557B3A",
                Tertiary = "#303030",
                TertiaryContrastText = "#DAF0FC",
                TextPrimary = "#FFFFFF",
                TextSecondary = "#B0BEC5",
                Warning = "#FFA500",
                Info = "#6E7582"
            },
            PaletteLight = new PaletteLight
            {
                ActionDefault = "#45B6EE",
                AppbarBackground = Colors.Blue.Darken1,
                DrawerBackground = Colors.Gray.Lighten5,
                Dark = Colors.Shades.Black,
                Divider = "#F5F5F5",
                Error = "#EE6352",
                ErrorDarken = "#EE6352",
                ErrorLighten = "#FFD3CE",
                GrayDark = "#A6A6A6",
                Primary = "#45B6EE",
                Secondary = "#DAF0FC",
                SecondaryContrastText = "#45B6EE",
                Success = "#98C581",
                SuccessDarken = "#98C581",
                Tertiary = "#F5F5F5",
                TertiaryContrastText = "#1E5973",
                TextPrimary = "#1E5973",
                TextSecondary = "#1E5973",
                Warning = "#FFBA08",
                Info = "#D9D9D9"
            },
            Typography = new Typography
            {
                Default = new Default
                {
                    FontFamily = ["Roboto", "sans-serif"]
                },
                H1 = new H1
                {
                    FontSize = "3rem",
                    FontWeight = 700,
                    LineHeight = 1.174
                },
                H2 = new H2
                {
                    FontSize = "2.5rem",
                    FontWeight = 700,
                    LineHeight = 1.174
                },
                H3 = new H3
                {
                    FontSize = "2rem",
                    FontWeight = 700,
                    LineHeight = 1.174
                },
                H4 = new H4
                {
                    FontSize = "1.5rem",
                    FontWeight = 700,
                    LineHeight = 1.174
                },
                H5 = new H5
                {
                    FontSize = "1.125rem",
                    FontWeight = 700,
                    LineHeight = 1.174
                },
                H6 = new H6
                {
                    FontSize = "1rem",
                    FontWeight = 700,
                    LineHeight = 1.174
                },
                Body1 = new Body1
                {
                    FontSize = "0.875rem",
                    LineHeight = 1.174
                },
                Body2 = new Body2
                {
                    FontSize = "0.75rem",
                    LineHeight = 1.174
                },
                Button = new Button
                {
                    FontSize = "0.75rem",
                    FontWeight = 600,
                    LineHeight = 1.174,
                    TextTransform = "none"
                },
                Subtitle1 = new Subtitle1
                {
                    FontSize = "1rem",
                    FontWeight = 600,
                    LineHeight = 1.174
                },
                Subtitle2 = new Subtitle2
                {
                    FontSize = "0.625rem",
                    FontWeight = 600,
                    LineHeight = 1.174
                }
            }
        };
}
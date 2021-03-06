﻿using System.Windows;
using System.Windows.Media;

namespace Lbc.WinPhone {
    internal static class Helper {
        public static Brush ToBrush(this Xamarin.Forms.Color color) {
            return new SolidColorBrush(color.ToMediaColor());
        }

        public static Color ToMediaColor(this Xamarin.Forms.Color color) {
            return Color.FromArgb((byte)(color.A * 255), (byte)(color.R * 255), (byte)(color.G * 255), (byte)(color.B * 255));
        }

        public static Thickness ToWinPhone(this Xamarin.Forms.Thickness t) {
            return new Thickness(t.Left, t.Top, t.Right, t.Bottom);
        }
    }
}

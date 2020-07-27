using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomControls
{
    public class ColorCheckBox : CheckBox
    {
        private static readonly Brush BackgroundBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));
        private static readonly Brush GlyphBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x21, 0x21, 0x21));
        private static readonly Brush DefaultBorderBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x70, 0x70, 0x70));
        private static readonly Brush MouseOverBackgroundBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0xF3, 0xF9, 0xFF));
        private static readonly Brush MouseOverBorderBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x55, 0x93, 0xFF));
        private static readonly Brush MouseOverGlyphBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x21, 0x21, 0x21));
        private static readonly Brush PressedBackgroundBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xEC, 0xFF));
        private static readonly Brush PressedBorderBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x3C, 0x77, 0xDD));
        private static readonly Brush PressedGlyphBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x21, 0x21, 0x21));
        private static readonly Brush DisabledBackgroundBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0xE6, 0xE6, 0xE6));
        private static readonly Brush DisabledBorderBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0xBC, 0xBC, 0xBC));
        private static readonly Brush DisabledGlyphBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x70, 0x70, 0x70));

        static ColorCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorCheckBox), new FrameworkPropertyMetadata(typeof(ColorCheckBox)));
        }
    }
}

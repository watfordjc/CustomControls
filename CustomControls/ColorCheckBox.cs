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


        public Brush Glyph
        {
            get { return (Brush)GetValue(GlyphProperty); }
            set { SetValue(GlyphProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Glyph.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GlyphProperty =
            DependencyProperty.Register("Glyph", typeof(Brush), typeof(ColorCheckBox), new PropertyMetadata(GlyphBrush));


        public Brush MouseOverGlyph
        {
            get { return (Brush)GetValue(MouseOverGlyphProperty); }
            set { SetValue(MouseOverGlyphProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverGlyph.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverGlyphProperty =
            DependencyProperty.Register("MouseOverGlyph", typeof(Brush), typeof(ColorCheckBox), new PropertyMetadata(MouseOverGlyphBrush));


        public Brush PressedGlyph
        {
            get { return (Brush)GetValue(PressedGlyphProperty); }
            set { SetValue(PressedGlyphProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PressedGlyph.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PressedGlyphProperty =
            DependencyProperty.Register("PressedGlyph", typeof(Brush), typeof(ColorCheckBox), new PropertyMetadata(PressedGlyphBrush));


        public Brush DisabledGlyph
        {
            get { return (Brush)GetValue(DisabledGlyphProperty); }
            set { SetValue(DisabledGlyphProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisabledGlyph.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisabledGlyphProperty =
            DependencyProperty.Register("DisabledGlyph", typeof(Brush), typeof(ColorCheckBox), new PropertyMetadata(DisabledGlyphBrush));


    }

    public class CheckBoxHelper : DependencyObject
    {
        public static Brush GetBackgroundColor(DependencyObject obj)
        {
            return (Brush)obj.GetValue(BackgroundColorProperty);
        }

        public static void SetBackgroundColor(DependencyObject obj, Brush value)
        {
            obj.SetValue(BackgroundColorProperty, value);
        }

        // Using a DependencyProperty as the backing store for BackgroundColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundColorProperty =
            DependencyProperty.RegisterAttached("BackgroundColor", typeof(Brush), typeof(CheckBoxHelper), new PropertyMetadata(Brushes.Blue));
    }
}

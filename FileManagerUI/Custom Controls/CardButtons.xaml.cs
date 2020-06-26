using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FileManagerUI.Custom_Controls
{
    /// <summary>
    /// Interaction logic for CardButtons.xaml
    /// </summary>
    public partial class CardButtons : UserControl
    {
        public CardButtons()
        {
            InitializeComponent();
        }


        public Uri imageSource
        {
            get { return (Uri)GetValue(imageSourceProperty); }
            set { SetValue(imageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for imageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty imageSourceProperty =
            DependencyProperty.Register("imageSource", typeof(Uri), typeof(CardButtons));



        public string text1
        {
            get { return (string)GetValue(text1Property); }
            set { SetValue(text1Property, value); }
        }

        // Using a DependencyProperty as the backing store for text1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty text1Property =
            DependencyProperty.Register("text1", typeof(string), typeof(CardButtons));



        public string text2
        {
            get { return (string)GetValue(text2Property); }
            set { SetValue(text2Property, value); }
        }

        // Using a DependencyProperty as the backing store for text2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty text2Property =
            DependencyProperty.Register("text2", typeof(string), typeof(CardButtons));

        public SolidColorBrush IconBackground
        {
            get { return (SolidColorBrush)GetValue(IconBackgroundProperty); }
            set { SetValue(IconBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBackgroundProperty =
            DependencyProperty.Register("IconBackground", typeof(SolidColorBrush), typeof(CardButtons));

        public SolidColorBrush IconBackgroundMouseOver
        {
            get { return (SolidColorBrush)GetValue(IconBackgroundMouseOverProperty); }
            set { SetValue(IconBackgroundMouseOverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IndicatorBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBackgroundMouseOverProperty =
            DependencyProperty.Register("IconBackgroundMouseOver", typeof(SolidColorBrush), typeof(CardButtons));

        public Brush ProgressTextColor
        {
            get { return (Brush)GetValue(ProgressTextProperty); }
            set { SetValue(ProgressTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IndicatorBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressTextProperty =
            DependencyProperty.Register("ProgressTextColor", typeof(Brush), typeof(CardButtons));

        public FontWeight ProgressTextWeight
        {
            get { return (FontWeight)GetValue(ProgressTextWeightProperty); }
            set { SetValue(ProgressTextWeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressTextWeightProperty =
            DependencyProperty.Register("ProgressTextWeight", typeof(FontWeight), typeof(CardButtons));

        public Brush ProgressTextColorMouseOver
        {
            get { return (Brush)GetValue(ProgressTextColorMouseOverProperty); }
            set { SetValue(ProgressTextColorMouseOverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IndicatorBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressTextColorMouseOverProperty =
            DependencyProperty.Register("ProgressTextColorMouseOver", typeof(Brush), typeof(CardButtons));

        public FontWeight ProgressTextWeightMouseOver
        {
            get { return (FontWeight)GetValue(ProgressTextWeightMouseOverProperty); }
            set { SetValue(ProgressTextWeightMouseOverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressTextWeightMouseOverProperty =
            DependencyProperty.Register("ProgressTextWeightMouseOver", typeof(FontWeight), typeof(CardButtons));


        public int Progress
        {
            get { return (int)GetValue(ProgressProperty); }
            set { SetValue(ProgressProperty, value); }
        }
        public int ProgressBarThickness
        {
            get { return (int)GetValue(ProgressBarThicknessProperty); }
            set { SetValue(ProgressBarThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArcThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressBarThicknessProperty =
            DependencyProperty.Register("ProgressBarThickness", typeof(int), typeof(CardButtons));

        // Using a DependencyProperty as the backing store for Progress.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressProperty =
            DependencyProperty.Register("Progress", typeof(int), typeof(CardButtons));

        public Brush ProgressIndicatorBrush
        {
            get { return (Brush)GetValue(ProgressIndicatorBrushProperty); }
            set { SetValue(ProgressIndicatorBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IndicatorBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressIndicatorBrushProperty =
            DependencyProperty.Register("ProgressIndicatorBrush", typeof(Brush), typeof(CardButtons));

        public Brush ProgressBackgroundBrush
        {
            get { return (Brush)GetValue(ProgressBackgroundBrushProperty); }
            set { SetValue(ProgressBackgroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressBackgroundBrushProperty =
            DependencyProperty.Register("ProgressBackgroundBrush", typeof(Brush), typeof(CardButtons));

        public Brush ProgressIndicatorBrushMouseOver
        {
            get { return (Brush)GetValue(ProgressIndicatorBrushMouseOverProperty); }
            set { SetValue(ProgressIndicatorBrushMouseOverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IndicatorBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressIndicatorBrushMouseOverProperty =
            DependencyProperty.Register("ProgressIndicatorBrushMouseOver", typeof(Brush), typeof(CardButtons));

        public Brush ProgressBackgroundBrushMouseOver
        {
            get { return (Brush)GetValue(ProgressBackgroundBrushMouseOverProperty); }
            set { SetValue(ProgressBackgroundBrushMouseOverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressBackgroundBrushMouseOverProperty =
            DependencyProperty.Register("ProgressBackgroundBrushMouseOver", typeof(Brush), typeof(CardButtons));

    }
}
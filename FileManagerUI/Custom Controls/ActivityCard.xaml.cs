using System;
using System.Windows;
using System.Windows.Controls;

namespace FileManagerUI.Custom_Controls
{
    /// <summary>
    /// Interaction logic for ActivityCard.xaml
    /// </summary>
    public partial class ActivityCard : UserControl
    {
        public ActivityCard()
        {
            InitializeComponent();
        }

        public bool IsVideo
        {
            get { return (bool)GetValue(IsVideoProperty); }
            set { SetValue(IsVideoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsVideo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsVideoProperty =
            DependencyProperty.Register("IsVideo", typeof(bool), typeof(ActivityCard));



        public string timeNormalText
        {
            get { return (string)GetValue(timeTextProperty); }
            set { SetValue(timeTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for timeText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty timeTextProperty =
            DependencyProperty.Register("timeText", typeof(string), typeof(ActivityCard));


        public string timeBoldText
        {
            get { return (string)GetValue(timeBoldTextProperty); }
            set { SetValue(timeBoldTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for timeBoldText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty timeBoldTextProperty =
            DependencyProperty.Register("timeBoldText", typeof(string), typeof(ActivityCard));



        public Uri Image1
        {
            get { return (Uri)GetValue(Image1Property); }
            set { SetValue(Image1Property, value); }
        }

        // Using a DependencyProperty as the backing store for Image1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Image1Property =
            DependencyProperty.Register("Image1", typeof(Uri), typeof(ActivityCard));



        public Uri Image2
        {
            get { return (Uri)GetValue(Image2Property); }
            set { SetValue(Image2Property, value); }
        }

        // Using a DependencyProperty as the backing store for Image2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Image2Property =
            DependencyProperty.Register("Image2", typeof(Uri), typeof(ActivityCard));

        public Uri Image3
        {
            get { return (Uri)GetValue(Image3Property); }
            set { SetValue(Image3Property, value); }
        }

        // Using a DependencyProperty as the backing store for Image3.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Image3Property =
            DependencyProperty.Register("Image3", typeof(Uri), typeof(ActivityCard));



        public Uri Image4
        {
            get { return (Uri)GetValue(Image4Property); }
            set { SetValue(Image4Property, value); }
        }

        // Using a DependencyProperty as the backing store for Image4.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Image4Property =
            DependencyProperty.Register("Image4", typeof(Uri), typeof(ActivityCard));

        public string descTextBeforeBold
        {
            get { return (string)GetValue(descTextBeforeBoldProperty); }
            set { SetValue(descTextBeforeBoldProperty, value); }
        }

        // Using a DependencyProperty as the backing store for descText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty descTextBeforeBoldProperty =
            DependencyProperty.Register("descTextBeforeBold", typeof(string), typeof(ActivityCard));

        public string descTextBold
        {
            get { return (string)GetValue(descTextBoldProperty); }
            set { SetValue(descTextBoldProperty, value); }
        }

        // Using a DependencyProperty as the backing store for descText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty descTextBoldProperty =
            DependencyProperty.Register("descTextBold", typeof(string), typeof(ActivityCard));

        public string descTextAfterBold
        {
            get { return (string)GetValue(descTextAfterBoldProperty); }
            set { SetValue(descTextAfterBoldProperty, value); }
        }

        // Using a DependencyProperty as the backing store for descText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty descTextAfterBoldProperty =
            DependencyProperty.Register("descTextAfterBold", typeof(string), typeof(ActivityCard));
    }
}

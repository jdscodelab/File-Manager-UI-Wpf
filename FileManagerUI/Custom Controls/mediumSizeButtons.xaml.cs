using System;
using System.Collections.Generic;
using System.Linq;
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

namespace FileManagerUI
{
    /// <summary>
    /// Interaction logic for mediumSizeButtons.xaml
    /// </summary>
    public partial class mediumSizeButtons : UserControl
    {
        public mediumSizeButtons()
        {
            InitializeComponent();
        }
        public ImageSource imageSource
        {
            get
            {
                return buttonImage.Source;
            }
            set
            {
                buttonImage.Source = value;
            }
        }
        public string text1
        {
            get
            {
                return Text1.Text;
            }
            set
            {
                Text1.Text = value;
            }
        }
        public string text2
        {
            get
            {
                return Text2.Text;
            }
            set
            {
                Text2.Text = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace boxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Configuration config;
        int x, y, z, px, py;
        public MainWindow()
        {
            InitializeComponent();

            XmlSerializer ser = new XmlSerializer(typeof(Configuration));
            using (StreamReader sr = new StreamReader("config.ini"))
            {
                config = (Configuration)ser.Deserialize(sr);
            }
            ComBoxPaperSel.ItemsSource = config.paperFormats.formats;
            ComBoxPaperSel.DisplayMemberPath = "Name";
            ComBoxPaperSel.SelectedItem = config.paperFormats.formats[0];
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            CheckInput();
            XmlSerializer ser = new XmlSerializer(typeof(Svg));
            using (StreamWriter sr = new StreamWriter("img.svg"))
            {
                ser.Serialize(sr, Template1.Create(x * 10, y * 10, z * 10, px, py));
            }
            System.Diagnostics.Process.Start("img.svg");
        }

        private void ComBoxPaperSel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Paper selItem = (Paper)ComBoxPaperSel.SelectedItem;
            PYTxt.Text = selItem.Height.ToString();
            PXTxt.Text = selItem.Width.ToString();
        }

        private void CheckBoxCustomPaper_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxCustomPaper.IsChecked)
            {
                PYTxt.IsEnabled = true;
                PXTxt.IsEnabled = true;
            }
            else
            {
                PYTxt.IsEnabled = false;
                PXTxt.IsEnabled = false;
                Paper selItem = (Paper)ComBoxPaperSel.SelectedItem;
                PYTxt.Text = selItem.Height.ToString();
                PXTxt.Text = selItem.Width.ToString();
            }
        }

        private void CheckBoxLandscape_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxLandscape.IsChecked)
            {
                Paper selItem = (Paper)ComBoxPaperSel.SelectedItem;
                PYTxt.Text = selItem.Width.ToString();
                PXTxt.Text = selItem.Height.ToString();
            }
            else
            {
                Paper selItem = (Paper)ComBoxPaperSel.SelectedItem;
                PYTxt.Text = selItem.Height.ToString();
                PXTxt.Text = selItem.Width.ToString();
            }
        }

        private void BtnCreatePrint_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Svg));
            using (StreamWriter sr = new StreamWriter("img.svg"))
            {
                ser.Serialize(sr, Template1.Create(x * 10, y * 10, z * 10, px, py));
            }

            PrintDialog printer = new PrintDialog();
            if (printer.ShowDialog() == true)
            {
               
            }



        }

        private void CheckInput()
        {
            if (!Int32.TryParse(XTxt.Text, out x))
            {
                MessageBox.Show("Wrong input format bitch!", "Bitch", MessageBoxButton.OK, MessageBoxImage.Error);
                MessageBox.Show("BITCH!", "BITCH", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!Int32.TryParse(YTxt.Text, out y))
            {
                MessageBox.Show("Wrong input format bitch!", "Bitch", MessageBoxButton.OK, MessageBoxImage.Error);
                MessageBox.Show("BITCH!", "BITCH", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!Int32.TryParse(ZTxt.Text, out z))
            {
                MessageBox.Show("Wrong input format bitch!", "Bitch", MessageBoxButton.OK, MessageBoxImage.Error);
                MessageBox.Show("BITCH!", "BITCH", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!Int32.TryParse(PXTxt.Text, out px))
            {
                MessageBox.Show("Wrong input format bitch!", "Bitch", MessageBoxButton.OK, MessageBoxImage.Error);
                MessageBox.Show("BITCH!", "BITCH", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!Int32.TryParse(PYTxt.Text, out py))
            {
                MessageBox.Show("Wrong input format bitch!", "Bitch", MessageBoxButton.OK, MessageBoxImage.Error);
                MessageBox.Show("BITCH!", "BITCH", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}

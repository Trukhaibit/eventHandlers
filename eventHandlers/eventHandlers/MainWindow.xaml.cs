using System;
using System.Collections.Generic;
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

namespace eventHandlers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MouseEnter(object sender, MouseEventArgs e)
        {
            if (c1.Fill == Brushes.Red)
            {
                c1.Fill = Brushes.Coral;
            }
            else
            {
                c1.Fill = Brushes.SeaGreen;
            }
        }

        private void MouseLeave(object sender, MouseEventArgs e)
        {
            if (c1.Fill == Brushes.SeaGreen)
            {
                c1.Fill = Brushes.Red;
            }
            else
            {
                c1.Fill = Brushes.DarkSeaGreen;
            }
                
        }

        private void MouseEnter3(object sender, MouseEventArgs e)
        {
            if (c3.Fill == Brushes.Red)
            {
                c3.Fill = Brushes.Coral;
            }
            else
            {
                c3.Fill = Brushes.SeaGreen;
            }
        }

        private void MouseLeave3(object sender, MouseEventArgs e)
        {
            if (c3.Fill == Brushes.SeaGreen)
            {
                c3.Fill = Brushes.Red;
            }
            else
            {
                c3.Fill = Brushes.DarkSeaGreen;
            }
        }

        private void MouseEnter2(object sender, MouseEventArgs e)
        {
            if (c2.Fill == Brushes.Red)
            {
                c2.Fill = Brushes.Coral;
            }
            else
            {
                c2.Fill = Brushes.SeaGreen;
            }
        }

        private void MouseLeave2(object sender, MouseEventArgs e)
        {
            if (c2.Fill == Brushes.SeaGreen)
            {
                c2.Fill = Brushes.Red;
            }
            else
            {
                c2.Fill = Brushes.DarkSeaGreen;
            }
        }

        private void btnOKClicked(object sender, MouseEventArgs e)
        {
            Button clickedButton = (Button)sender;
            MessageBox.Show(clickedButton.Name);
            this.Close();
        }

        private void KeyCount(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Key pressed is: " + e.Key.ToString());
        }
    }
}

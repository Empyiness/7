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
using Sets;

namespace _5
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
        bool handEnter;
        Vector3D vector1,
                 vector2;
        private void CheckedHandEnter(object sender, RoutedEventArgs e)
        {
            handEnter = true;
            XBox.IsEnabled = true;
            YBox.IsEnabled = true;
            ZBox.IsEnabled = true;
        }

        private void UncheckedHandEnter(object sender, RoutedEventArgs e)
        {
            handEnter = false;
            XBox.IsEnabled = false;
            YBox.IsEnabled = false;
            ZBox.IsEnabled = false;
        }

        private void CreateVector1(object sender, RoutedEventArgs e)
        {
            if (handEnter)
            {
                if (!int.TryParse(XBox.Text, out int x))
                {
                    MessageBox.Show("Некорректная координата x!");
                    return;
                }
                if (!int.TryParse(YBox.Text, out int y))
                {
                    MessageBox.Show("Некорректная координата y!");
                    return;
                }
                if (!int.TryParse(ZBox.Text, out int z))
                {
                    MessageBox.Show("Некорректная координата z!");
                    return;
                }
                vector1 = new Vector3D(x, y, z);
                Vector1Box.Text = vector1.ToString();
                Clear();
                Calculate();
                return;
            }
            vector1 = new Vector3D();
            Vector1Box.Text = vector1.ToString();
            Clear();
            Calculate();
        }

        private void CreateVector2(object sender, RoutedEventArgs e)
        {
            if (handEnter)
            {
                if (!int.TryParse(XBox.Text, out int x))
                {
                    MessageBox.Show("Некорректная координата x!");
                    return;
                }
                if (!int.TryParse(YBox.Text, out int y))
                {
                    MessageBox.Show("Некорректная координата y!");
                    return;
                }
                if (!int.TryParse(ZBox.Text, out int z))
                {
                    MessageBox.Show("Некорректная координата z!");
                    return;
                }
                vector2 = new Vector3D(x, y, z);
                Vector2Box.Text = vector2.ToString();
                Clear();
                Calculate();
                return;
            }
            vector2 = new Vector3D();
            Vector2Box.Text = vector2.ToString();
            Clear();
            Calculate();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Митин ИСП-31 Использовать класс Triad (тройка чисел). Разработать операцию для сложения \r\nтриады с числом. Разработать операцию для сложения элементов одой триады с \r\nдругой триадой.");
        }
        private void Close (object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void Clear()
        {
            XBox.Clear();
            YBox.Clear();
            ZBox.Clear();
            VectorSumBox.Clear();
            VectorMultiplyBox.Clear();
        }
        public void Calculate()
        {
            if (vector1 != null && vector2 != null)
            {
                VectorSumBox.Text = (vector1 + vector2).ToString();
                VectorMultiplyBox.Text = (vector1 * vector2).ToString();
            }
        }
    }
}

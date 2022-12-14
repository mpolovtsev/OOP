using System.Windows;
using ExeptionsLibrary;

namespace App
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VectorLibrary.Vector vector1;
        VectorLibrary.Vector vector2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddBttn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                vector1 = new VectorLibrary.Vector(double.Parse(FieldX1.Text), double.Parse(FieldY1.Text),
                    double.Parse(FieldZ1.Text));
                vector2 = new VectorLibrary.Vector(double.Parse(FieldX2.Text), double.Parse(FieldY2.Text),
                    double.Parse(FieldZ2.Text));
            }
            catch
            {
                MessageBox.Show("Некорректные данные.");
            }
        }

        private void ScalarProductBttn_Click(object sender, RoutedEventArgs e)
        {
            ScalarProductTb.Text = (vector1 * vector2).ToString();
        }

        private void VectorProductBttn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VectorLibrary.Vector result = vector1 ^ vector2;
                VectorProductTb.Text = $"{result.x}, {result.y}, {result.z}";
            }
            catch (VectorException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void NumberProductBttn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double number = double.Parse(Number.Text);
                VectorLibrary.Vector result = vector1 * number;
                NumberProductTb.Text = $"{result.x}, {result.y}, {result.z}";
            }
            catch
            {
                MessageBox.Show("Некорректные данные.");
            }
        }
    }
}

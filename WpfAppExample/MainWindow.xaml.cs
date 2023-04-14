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

namespace WpfAppExample
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

        public string textBoxText;

        public List<Point> textList = new List<Point>();


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            textBoxText = MyTextBox.Text;

            MessageBox.Show(textBoxText);

            MyListbox.ItemsSource = textList;

            Combo1.ItemsSource = textList;

        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = new Point();
            point = e.GetPosition(MyCanvas);

            //MessageBox.Show(point.X.ToString()+ " , " + point.Y.ToString());

            string xyz = point.X.ToString() + " , " + point.Y.ToString();

            textList.Add(point);



            //MyLabel.Content = xyz;



        }
    }
}

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

namespace Canvas_Sunflower
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Ellipse lisc = new Ellipse
            {
                Width = 30,
                Height = 50,
                Fill = Brushes.Green,
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                RenderTransform = new RotateTransform(-40, 50, 60) // Obrót wokół środka
            };
            Canvas.SetLeft(lisc, 365);
            Canvas.SetTop(lisc, 200);
            P.Children.Add(lisc);

            //Add petals
            // Uwzględnji wymiary flower, aby kwiatki nie były w flowerze
            for (int i = 0; i < 12; i++)
            {
                Ellipse petal = new Ellipse
                {
                    Width = 40,
                    Height = 80,
                    Fill = Brushes.Orange,
                    Stroke = Brushes.Red,
                    StrokeThickness = 2,
                    RenderTransform = new RotateTransform(i * 30, 20, 70) // Obrót wokół środka dolnej krawędzi
                };
                Canvas.SetLeft(petal, 360); // Ustawienie pozycji względem flower
                Canvas.SetTop(petal, 100);
                P.Children.Add(petal);
            }

            Polygon doniczka = new Polygon
            {
                Fill = Brushes.SaddleBrown,   // kolor doniczki
                Stroke = Brushes.Black,       // obramowanie
                StrokeThickness = 2
            };
            doniczka.Points = new PointCollection()
            {
                new Point(0, 0),
                new Point(100, 0),
                new Point(80, 80),
                new Point(20, 80)
            };



            Canvas.SetLeft(doniczka, 330);
            Canvas.SetTop(doniczka, 270);



            Polygon lodyga = new Polygon
            {
                Fill = Brushes.Green,        // kolor łodygi
                Stroke = Brushes.Black,      // obramowanie
                StrokeThickness = 2
            };
            lodyga.Points = new PointCollection()
            {
                new Point(0, 80),
                new Point(8, 80),
                new Point(3, 0),
                new Point(-5, 0)
            };

            Ellipse flower = new Ellipse
            {
                Width = 100,
                Height = 100,
                Fill = Brushes.Yellow,
                Stroke = Brushes.Orange,
                StrokeThickness = 4
            };
            Canvas.SetLeft(flower, 330);
            Canvas.SetTop(flower, 120);


            Canvas.SetLeft(lodyga, 380);
            Canvas.SetTop(lodyga, 200);
            P.Children.Add(lodyga);
            P.Children.Add(doniczka);
            P.Children.Add(flower);


            Ellipse eye = new Ellipse
            {
                Width = 20,
                Height = 32,
                Fill = Brushes.Black
            };
            Ellipse eye2 = new Ellipse
            {
                Width = 20,
                Height = 32,
                Fill = Brushes.Black
            };


            Canvas.SetLeft(eye, 350);
            Canvas.SetTop(eye, 147);
            P.Children.Add(eye);
            Canvas.SetLeft(eye2, 397);
            Canvas.SetTop(eye2, 147);
            P.Children.Add(eye2);


            Ellipse zrenica = new Ellipse
            {
                Width = 8,
                Height = 12,
                Fill = Brushes.White
            };
            Canvas.SetLeft(zrenica, 358);
            Canvas.SetTop(zrenica, 155);
            P.Children.Add(zrenica);
            Ellipse zrenica2 = new Ellipse
            {
                Width = 8,
                Height = 12,
                Fill = Brushes.White
            };
            Canvas.SetLeft(zrenica2, 405);
            Canvas.SetTop(zrenica2, 155);
            P.Children.Add(zrenica2);

            Polygon mouth = new Polygon
            {
                Fill = Brushes.Black,        // kolor ust
                Stroke = Brushes.Black,      // obramowanie
                StrokeThickness = 2
            };

            mouth.Points = new PointCollection()
            {
                new Point(0, 0),
                new Point(40, 0),
                new Point(30, 2),
                new Point(10, 2)
            };
            Canvas.SetLeft(mouth, 360);
            Canvas.SetTop(mouth, 190);
            P.Children.Add(mouth);

            Polygon mouth2 = new Polygon
            {
                Fill = Brushes.Red,        // kolor ust
                Stroke = Brushes.Black,      // obramowanie
                StrokeThickness = 2
            };
            mouth2.Points = new PointCollection()
            {
                new Point(0, 2),
                new Point(40, 2),
                new Point(30, 6),
                new Point(10, 6)
            };
            Canvas.SetLeft(mouth2, 360);
            Canvas.SetTop(mouth2, 190);
            P.Children.Add(mouth2);



        }
    }
}
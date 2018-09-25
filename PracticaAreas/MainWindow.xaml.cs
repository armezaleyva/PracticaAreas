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

namespace PracticaAreas {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            float baseRectangulo = float.Parse(txtBaseRectangulo.Text);
            float alturaRectangulo = float.Parse(txtAlturaRectangulo.Text);
            float areaRectangulo = baseRectangulo * alturaRectangulo;
            lblAreaRectangulo.Text = areaRectangulo.ToString();
        }

        private void btnTriangulo_Click(object sender, RoutedEventArgs e) {
            float baseTriangulo = float.Parse(txtBaseTriangulo.Text);
            float alturaTriangulo = float.Parse(txtAlturaTriangulo.Text);
            float areaRectangulo = (baseTriangulo * alturaTriangulo) / 2;
            lblAreaTriangulo.Text = areaRectangulo.ToString();
        }

        private void btnCirculo_Click(object sender, RoutedEventArgs e) {
            float radioCirculo = float.Parse(txtBaseCirculo.Text);
            float areaCirculo =  (float)Math.PI * (radioCirculo * radioCirculo);
            lblAreaCirculo.Text = areaCirculo.ToString();
        }

        private void btnTrapecio_Click(object sender, RoutedEventArgs e) {
            float baseMayorTrapecio = float.Parse(txtBaseMayorTrapecio.Text);
            float baseMenorTrapecio = float.Parse(txtBaseMenorTrapecio.Text);
            float alturaTrapecio = float.Parse(txtAlturaTrapecio.Text);
            float areaTrapecio = ((baseMayorTrapecio + baseMenorTrapecio) / 2) * alturaTrapecio;
            lblAreaTrapecio.Text = areaTrapecio.ToString();
        }
    }
}

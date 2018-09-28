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

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            panelConfiguracion.Children.Clear();
            switch (cbTipoFigura.SelectedIndex) {
                case 0: // Rectángulo
                    panelConfiguracion.Children.Add(new ControlAreaRectangulo());
                    break;
                case 1: // Triángulo
                    panelConfiguracion.Children.Add(new ControlAreaTriangulo());
                    break;
                case 2: // Círculo
                    panelConfiguracion.Children.Add(new ControlAreaCirculo());
                    break;
                case 3: // Trapecio
                    panelConfiguracion.Children.Add(new ControlAreaTrapecio());
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            double area = 0.0;
            switch(cbTipoFigura.SelectedIndex) {
                case 0: // Rectángulo
                    var controlAreaRectangulo = (ControlAreaRectangulo)panelConfiguracion.Children[0];
                    float baseRectangulo = float.Parse(controlAreaRectangulo.txtBaseRectangulo.Text);
                    float alturaRectangulo = float.Parse(controlAreaRectangulo.txtBaseRectangulo.Text);
                    area = baseRectangulo * alturaRectangulo;
                    break;
                case 1: // Triángulo
                    var controlAreaTriangulo = (ControlAreaTriangulo)panelConfiguracion.Children[0];
                    float baseTriangulo = float.Parse(controlAreaTriangulo.txtBaseTriangulo.Text);
                    float alturaTriangulo = float.Parse(controlAreaTriangulo.txtAlturaTriangulo.Text);
                    area = (baseTriangulo * alturaTriangulo) / 2;
                    break;
                case 2: // Círculo
                    var controlAreaCirculo = (ControlAreaCirculo)panelConfiguracion.Children[0];
                    float radioCirculo = float.Parse(controlAreaCirculo.txtBaseCirculo.Text);
                    area = (float)Math.PI * (radioCirculo * radioCirculo);
                    break;
                case 3: // Trapecio
                    var controlAreaTrapecio = (ControlAreaTrapecio)panelConfiguracion.Children[0];
                    float baseMayorTrapecio = float.Parse(controlAreaTrapecio.txtBaseMayorTrapecio.Text);
                    float baseMenorTrapecio = float.Parse(controlAreaTrapecio.txtBaseMenorTrapecio.Text);
                    float alturaTrapecio = float.Parse(controlAreaTrapecio.txtAlturaTrapecio.Text);
                    area = ((baseMayorTrapecio + baseMenorTrapecio) / 2) * alturaTrapecio;
                    break;
                default:
                    break;
            }
            lblResultadoArea.Text = area.ToString();

        }
    }
}

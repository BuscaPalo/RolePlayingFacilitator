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

namespace RPF.Visual
{
    /// <summary>
    /// Lógica de interacción para Personaje.xaml
    /// </summary>
    public partial class Personaje : UserControl
    {
        public Personaje()
        {
            InitializeComponent();
            //TODO: Setear bien con la DB
            in_nombre.DataContext = new InputData
            {
                TypeData = "Comete esta",
                Data = "forro"
            };
            Num = 100;
        }

        public string Hola { get; set; }
        public int Num { get; set; }
    }
}

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
    /// Lógica de interacción para TextInfoInput.xaml
    /// </summary>
    public partial class TextInfoInput : UserControl
    {
        public TextInfoInput()
        {
            InitializeComponent();
            TypeData = "asd";
            Data = "Chau";
        }



        public string TypeData
        {
            get { return (string)GetValue(TypeDataProperty); }
            set
            {
                SetValue(TypeDataProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for TypeData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TypeDataProperty =
            DependencyProperty.Register("TypeData", typeof(string), typeof(TextInfoInput), new PropertyMetadata(""));

        public string Data
        {
            get { return (string)GetValue(DataProperty); }
            set
            {
                SetValue(DataProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for Data.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register("Data", typeof(string), typeof(TextInfoInput), new PropertyMetadata(""));



    }
}

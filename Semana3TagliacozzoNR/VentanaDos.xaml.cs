using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3TagliacozzoNR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentanaDos : ContentPage
    {
        public VentanaDos(string usuario, string clave)
        {
            InitializeComponent();
            lblUser.Text = "USUARIO: " + usuario;
            lblPass.Text = "CLAVE: "+clave;
        }
    }
}
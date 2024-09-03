using Microsoft.Maui.Controls;

namespace Equipe1
{
    public partial class Pedido : ContentPage
    {
        public Pedido()
        {
            InitializeComponent();
        }

         void VoltarInicio(object sender, EventArgs e)
  {
    Application.Current.MainPage = new Inicio();
  }
      void ListadePedidos(object sender, EventArgs e)
  {
    Application.Current.MainPage = new ListaDePedidos();
  }
  
    }
}

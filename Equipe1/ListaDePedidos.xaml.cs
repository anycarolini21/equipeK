using Microsoft.Maui.Controls;

namespace Equipe1
{
    public partial class ListaDePedidos : ContentPage
    {
        public ListaDePedidos()
        {
            InitializeComponent();
        }
            void VoltarPedido(object sender, EventArgs e)
  {
    Application.Current.MainPage = new Pedido();
  }

              void Irparafrente(object sender, EventArgs e)
  {
    Application.Current.MainPage = new CadastroDePedidos();
  }
        
    }
}

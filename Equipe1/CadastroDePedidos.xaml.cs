using Microsoft.Maui.Controls;

namespace Equipe1
{
    public partial class CadastroDePedidos : ContentPage
    {
        public CadastroDePedidos()
        {
            InitializeComponent();
        }
          void Voltar1(object sender, EventArgs e)
  {
    Application.Current.MainPage = new ListaDePedidos();
  }

            void Ir1(object sender, EventArgs e)
  {
    Application.Current.MainPage = new RealizacaoPag();
  }
    }
}

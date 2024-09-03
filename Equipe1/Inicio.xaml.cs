using Microsoft.Maui.Controls;

namespace Equipe1
{
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }
    
    void TrocarDePagina(object sender, EventArgs e)
  {
    Application.Current.MainPage = new Pedido();
  }
  void TrocarFornecedor(object sender, EventArgs e)
  {
    Application.Current.MainPage = new Pedido();
  }

    
    
    }
}

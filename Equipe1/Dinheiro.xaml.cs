using Microsoft.Maui.Controls;

namespace Equipe1
{
    public partial class Dinheiro : ContentPage
    {
        public Dinheiro()
        {
            InitializeComponent();
        }
                                void Voltar4(object sender, EventArgs e)
  {
    Application.Current.MainPage = new RealizacaoPag();
  }
    }
}

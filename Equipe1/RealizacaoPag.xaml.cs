using Microsoft.Maui.Controls;

namespace Equipe1
{
    public partial class RealizacaoPag: ContentPage
    {
        public RealizacaoPag()
        {
            InitializeComponent();
        }
                      void Voltar2(object sender, EventArgs e)
  {
    Application.Current.MainPage = new CadastroDePedidos();
  }

                        void PagarDinheiro(object sender, EventArgs e)
  {
    Application.Current.MainPage = new Dinheiro();
  }

                        void PagarCartao(object sender, EventArgs e)
  {
    Application.Current.MainPage = new Cartao();
  }

                        void Pagarpix(object sender, EventArgs e)
  {
    Application.Current.MainPage = new Pix();
  }
    }
}

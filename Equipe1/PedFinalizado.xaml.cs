using Microsoft.Maui.Controls;

namespace Equipe1
{
    public partial class PedFinalizado : ContentPage
    {
        public PedFinalizado()
        {
            InitializeComponent();
        }

        private async void VoltarParaTelaInicial_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

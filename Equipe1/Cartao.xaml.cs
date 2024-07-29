using Microsoft.Maui.Controls;

namespace Equipe1 
{
    public partial class Cartao : ContentPage
    {
        public Cartao()
        {
            InitializeComponent();
        }

        private void OnCreditoClicked(object sender, EventArgs e)
        {
            // Lógica para quando o botão de crédito for clicado
            // Exemplo: Navegar para outra página ou mostrar um alerta
            DisplayAlert("Crédito", "Você escolheu crédito.", "OK");
        }

        private void OnDebitoClicked(object sender, EventArgs e)
        {
            // Lógica para quando o botão de débito for clicado
            // Exemplo: Navegar para outra página ou mostrar um alerta
            DisplayAlert("Débito", "Você escolheu débito.", "OK");
        }
    }
}

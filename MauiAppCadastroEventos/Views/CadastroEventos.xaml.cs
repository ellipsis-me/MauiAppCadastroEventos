using MauiAppCadastroEventos.Models;

namespace MauiAppCadastroEventos.Views;

public partial class CadastroEventos : ContentPage
{

    public CadastroEventos()
	{
		InitializeComponent();

        dtpck_inicio.MinimumDate = DateTime.Now;

        dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Evento ev = new Evento
            {
                Nome = txt_evento.Text,
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
                CustoPorParticipante = Convert.ToInt32(double_custo_participante.Text),
                NumeroParticipantes = Convert.ToInt32(stp_participantes.Value),
                Local = txt_local.Text
            };
            await Navigation.PushAsync(new Resultado()
            {
                BindingContext = ev
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}
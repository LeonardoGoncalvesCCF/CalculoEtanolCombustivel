namespace CalculoEtanolCombustivel
{
    public partial class MainPage : ContentPage
    {
  

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try //Criando try catch para tratar possiveis erros
            {
                //convertendo string para double
                double etanol = Convert.ToDouble(txt_etanol.Text); 
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol está compensando.";
                }
                else
                {
                    msg = "A gasolina está compensando.";
                }

                DisplayAlert("Calculado", msg, "ok");

            }
            catch (Exception ex) //Mensagem de erro
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        }
    }

}

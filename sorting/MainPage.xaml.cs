namespace sorting
{
    public partial class MainPage : ContentPage
    {
 

        public MainPage()
        {
            InitializeComponent();
        }
        private void Btn1_Clicked(object sender, EventArgs e)
        {

            float[] X = new float[5];

            float.TryParse(XX1.Text, out X[0]);
            float.TryParse(XX2.Text, out X[1]);
            float.TryParse(XX3.Text, out X[2]);
            float.TryParse(XX4.Text, out X[3]);
            float.TryParse(XX5.Text, out X[4]);

            Array.Sort(X);

            XX1.Text = X[0].ToString();
            XX2.Text = X[1].ToString();
            XX3.Text = X[2].ToString();
            XX4.Text = X[3].ToString();
            XX5.Text = X[4].ToString();
        }

    }

}

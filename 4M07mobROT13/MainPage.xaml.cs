namespace _4M07mobROT13
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }
        private void btnSzyfruj(object sender, EventArgs e)
        {
            string s = entJawny.Text.ToLower();
            string w = "";
            string litery = "abcdefghijklmnopqrstuvwxyz";
            foreach(var c in s)
            {
                if (c >= 'a' && c <= 'z')
                {
                    int poz = (litery.IndexOf(c) + 13) % 26;
                    w += litery[poz];
                }
            }
                

            /*
            char znak;
            foreach(var c in s)
            {
                if (c >= 'a' && c <= 'z')
                {
                    znak = (char)(c + 13);
                    if (znak > 'z')
                        znak = (char)(znak - 26);
                    w += znak;
                }
                else
                    w += c;
            }
            */
            entZaszyfr.Text = w;

        }


    }

}

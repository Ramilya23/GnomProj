using System.Reflection.Metadata;

namespace GnomProj
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        
        public MainPage()
        {
            InitializeComponent();
        }

        private async void regB_Clicked(object sender, EventArgs e)
        {
           
            if ((fieldNoEmpty(login.Text)))
            {
                await Navigation.PushModalAsync(new Home());
            }
            else
            {
                await DisplayAlert("Ошибка!", "Заполните все поля", "ок");
            }
            

        }
        public bool fieldNoEmpty(string fieldTxt) {
            if (fieldTxt == " "  || fieldTxt == string.Empty || fieldTxt == null)
            {
                
                return false;
            }
            else
            {
                return true;
            }

            
        }
        public bool Password(string passText, string recpassText)
        {
            if (passText==recpassText)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void recpassEnt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!fieldNoEmpty(recpassEnt.Text))
            {
                passNo.IsVisible = false;
                return;
            }
            if (Password(passEnt.Text, recpassEnt.Text) == false)
            {
                passNo.IsVisible = true; 
            }
            else
            {
                passNo.IsVisible = false;
            }

        }
    }

}

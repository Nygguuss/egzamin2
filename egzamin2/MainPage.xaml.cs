using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace egzamin2
{
    public partial class MainPage : ContentPage
    {
        List<Image> images = new List<Image>();
        Gallery gallery;

        public MainPage()
        {
            InitializeComponent();
            images.Add(new Image { Source = "pig.jpg" });
            images.Add(new Image { Source = "minion.jpg" });
            images.Add(new Image { Source = "truck.jpg" });
            images.Add(new Image { Source = "cat.jpg" });;
            gallery = new Gallery(images);
        }




        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            Switch thisSender = (Switch)sender;
            if(thisSender.IsToggled)
            {
                Color myRgbColor = new Color();
                myRgbColor = Color.FromRgb(24, 42, 212);
                mybac.BackgroundColor = myRgbColor;
            }
            else
            {
                Color myRgbColor = new Color();
                myRgbColor = Color.FromRgb(0, 76, 64);
                mybac.BackgroundColor = myRgbColor;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            gallery.MovePrevious();
            miejsce_zdj.Source = gallery.GetCurrentImage().Source;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            gallery.MoveNext();
            miejsce_zdj.Source = gallery.GetCurrentImage().Source;
        }
    }
}

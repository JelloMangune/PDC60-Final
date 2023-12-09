using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PDC60_FinalProject.Model;

namespace PDC60_FinalProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage : ContentPage
    {
        public CarouselPage()
        {
            InitializeComponent();

            List<ImageModel> images = new List<ImageModel>()
            {
                new ImageModel(){Title="Image 1",Url="https://upload.wikimedia.org/wikipedia/commons/9/9c/9422jfAngeles_University_Foundation_Roadsfvf_18.JPG"},
                new ImageModel(){Title="Image 2",Url="https://i.ytimg.com/vi/Er-Uzr7_M8o/maxresdefault.jpg"},
                new ImageModel(){Title="Image 3",Url="https://photos.wikimapia.org/p/00/01/27/09/03_big.jpg"}
            };

            Carousel.ItemsSource = images;

            Device.StartTimer(TimeSpan.FromSeconds(4), (Func<bool>)(() =>
            {
                Carousel.Position = (Carousel.Position + 1) % images.Count;
                return true;
            }));
        }

        private async void btnViewRecord_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
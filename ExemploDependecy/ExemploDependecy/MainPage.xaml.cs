using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExemploDependecy
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblInfo.Text = DependencyService.Get<ISOInfo>().Dados;

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
             DependencyService.Get<IMedia>().Play();
        }
    }
}

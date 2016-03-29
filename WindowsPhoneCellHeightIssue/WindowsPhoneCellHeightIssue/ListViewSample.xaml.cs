using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WindowsPhoneCellHeightIssue
{
    public partial class ListViewSample : ContentPage
    {
        public ListViewSample()
        {
            InitializeComponent();

            BindingContext = this;

            ShowModal.Clicked += (s, e) =>
            {
                Navigation.PushModalAsync(new ContentPage());
            };

        }

        public List<string> Cards { get; set; } = new List<string> { "a", "b", "c", "d", "e", "f" };
    }
}

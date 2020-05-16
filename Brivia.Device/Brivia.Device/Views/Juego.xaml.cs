using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Brivia.Device.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Juego : ContentPage
	{
		public Juego ()
		{
			InitializeComponent ();
            InitButtons();
        }

        private void InitButtons()
        {
            List<string> myList = new List<string>()
            {
                "Test1",
                "Test2"
            };
            foreach (var item in myList)
            {
                var btn = new Button()
                {
                    Text = item,
                    StyleId = item
                };

                // handler
                MyButtons.Children.Add(btn);
            }
        }
    }
}
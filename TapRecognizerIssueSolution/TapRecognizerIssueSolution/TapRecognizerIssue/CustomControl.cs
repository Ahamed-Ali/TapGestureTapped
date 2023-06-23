
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapRecognizerIssue
{
    internal class CustomParentBoxView : ContentView
    {
        public CustomParentBoxView()
        {
           
            var absoluteLayout = new AbsoluteLayout();
            Content = absoluteLayout;

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnBoxTapped;
            this.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private void OnBoxTapped(object sender, EventArgs e)
        {
            BackgroundColor = BackgroundColor == Colors.Red ? Colors.Green : Colors.Red;
        }
    }

}

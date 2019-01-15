using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrientationApp
{
    public partial class MainPage : BasePage
    {
        
        public MainPage()
        {
            InitializeComponent();
            visualElement = new List<VisualElement>()
            {
                ImageLayout,
                InfoLayout
            };
        }
    }
}

using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OrientationApp
{
    public class BasePage : ContentPage
    {
        public List<VisualElement> visualElement { get; set; }
        public BasePage()
        {
            DeviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;
        }
        void OnMainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            var displayInfo = e.DisplayInfo.Orientation;
            if (displayInfo == DisplayOrientation.Portrait)
            {
                foreach (var views in visualElement)
                {
                    VisualStateManager.GoToState(views, "Portrait");
                }
            }
            else
            {
                foreach (var views in visualElement)
                {
                    VisualStateManager.GoToState(views, "Landscape");
                }
            }
        }
    }
}
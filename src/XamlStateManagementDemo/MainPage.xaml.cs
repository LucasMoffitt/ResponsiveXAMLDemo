using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XamlStateManagementDemo
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            SizeChanged += MainPage_SizeChanged;
        }

        private void MainPage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            VisualStateManager.GoToState(this, GetState(e.NewSize.Width), true);
            ScreenWidth.Text = e.NewSize.Width.ToString();
        }
        
        private string GetState(double width)
        {
            if (width <= 500)
                return "Snapped";

            if (width <= 660)
                return "EvenSmaller";

            if (width <= 755)
                return "Smaller";

            return "Default";
        }
    }
}

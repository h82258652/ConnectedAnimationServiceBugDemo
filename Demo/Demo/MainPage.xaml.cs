using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Animation;

namespace Demo
{
    public sealed partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void FireButton_Click(object sender, RoutedEventArgs e)
        {
            var connectedAnimationService = ConnectedAnimationService.GetForCurrentView();
            var connectedAnimation = connectedAnimationService.PrepareToAnimate("Animation", AnimationSource);
            connectedAnimation.TryStart(AnimationTarget);

            AnimationSource.Opacity = 0;
        }
    }
}
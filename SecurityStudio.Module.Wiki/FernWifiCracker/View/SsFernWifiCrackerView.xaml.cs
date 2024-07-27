using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.FernWifiCracker.ViewModel;

namespace SecurityStudio.Module.Wiki.FernWifiCracker.View
{
    public partial class SsFernWifiCrackerView : SsView
    {
        public SsFernWifiCrackerView(SsFernWifiCrackerViewModel ssFernWifiCrackerViewModel)
            : base(ssFernWifiCrackerViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.OxygenForensicDetective.ViewModel;

namespace SecurityStudio.Module.Wiki.OxygenForensicDetective.View
{
    public partial class SsOxygenForensicDetectiveView : SsView
    {
        public SsOxygenForensicDetectiveView(
            SsOxygenForensicDetectiveViewModel ssOxygenForensicDetectiveViewModel)
            : base(ssOxygenForensicDetectiveViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}
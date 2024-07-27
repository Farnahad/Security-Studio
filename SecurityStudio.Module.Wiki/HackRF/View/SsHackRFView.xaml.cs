using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.HackRF.ViewModel;

namespace SecurityStudio.Module.Wiki.HackRF.View
{
    public partial class SsHackRFView : SsView
    {
        public SsHackRFView(SsHackRFViewModel ssHackRFViewModel)
            : base(ssHackRFViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}
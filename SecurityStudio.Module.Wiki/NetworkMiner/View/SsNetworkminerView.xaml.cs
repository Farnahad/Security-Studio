using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.NetworkMiner.ViewModel;

namespace SecurityStudio.Module.Wiki.NetworkMiner.View
{
    public partial class SsNetworkMinerView : SsView
    {
        public SsNetworkMinerView(SsNetworkMinerViewModel ssNetworkMinerViewModel)
            : base(ssNetworkMinerViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}
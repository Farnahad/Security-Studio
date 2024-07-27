using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Vega.ViewModel;

namespace SecurityStudio.Module.Wiki.Vega.View
{
    public partial class SsVegaView : SsView
    {
        public SsVegaView(SsVegaViewModel ssVegaViewModel)
            : base(ssVegaViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}
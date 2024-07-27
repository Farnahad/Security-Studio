using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.OwaspZap.ViewModel;

namespace SecurityStudio.Module.Wiki.OwaspZap.View
{
    public partial class SsOwaspZapView : SsView
    {
        public SsOwaspZapView(SsOwaspZapViewModel ssOwaspZapViewModel)
            : base(ssOwaspZapViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}
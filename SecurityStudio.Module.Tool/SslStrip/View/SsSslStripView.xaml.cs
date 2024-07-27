using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.SslStrip.ViewModel;

namespace SecurityStudio.Module.Tool.SslStrip.View
{
    public partial class SsSslStripView : SsView
    {
        public SsSslStripView(SsSslStripViewModel ssSslStripViewModel)
            : base(ssSslStripViewModel)
        {
            InitializeComponent();
        }
    }
}
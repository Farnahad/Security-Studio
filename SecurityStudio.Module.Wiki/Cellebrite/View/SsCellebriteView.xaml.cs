using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Cellebrite.ViewModel;

namespace SecurityStudio.Module.Wiki.Cellebrite.View
{
    public partial class SsCellebriteView : SsView
    {
        public SsCellebriteView(SsCellebriteViewModel ssCellebriteViewModel)
            : base(ssCellebriteViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}
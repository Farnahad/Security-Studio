using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Belkasoft.ViewModel;

namespace SecurityStudio.Module.Wiki.Belkasoft.View
{
    public partial class SsBelkasoftView : SsView
    {
        public SsBelkasoftView(SsBelkasoftViewModel ssBelkasoftViewModel)
            : base(ssBelkasoftViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}
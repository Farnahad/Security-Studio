using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.SecTools.ViewModel;

namespace SecurityStudio.Module.Wiki.SecTools.View
{
    public partial class SsSecToolsView : SsView
    {
        public SsSecToolsView(SsSecToolsViewModel ssSecToolsViewModel)
            : base(ssSecToolsViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}
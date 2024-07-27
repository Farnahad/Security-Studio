using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.ScadaPass.ViewModel;

namespace SecurityStudio.Module.Wiki.ScadaPass.View
{
    public partial class SsScadaPassView : SsView
    {
        public SsScadaPassView(SsScadaPassViewModel ssScadaPassViewModel)
            : base(ssScadaPassViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Attifyos.ViewModel;

namespace SecurityStudio.Module.Wiki.Attifyos.View
{
    public partial class SsAttifyosView : SsView
    {
        public SsAttifyosView(SsAttifyosViewModel ssAttifyosViewModel)
            : base(ssAttifyosViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}
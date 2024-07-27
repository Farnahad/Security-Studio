using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.MimiPenguin.ViewModel;

namespace SecurityStudio.Module.Tool.MimiPenguin.View
{
    public partial class SsMimiPenguinView : SsView
    {
        public SsMimiPenguinView(SsMimiPenguinViewModel ssMimiPenguinViewModel)
            : base(ssMimiPenguinViewModel)
        {
            InitializeComponent();
        }
    }
}
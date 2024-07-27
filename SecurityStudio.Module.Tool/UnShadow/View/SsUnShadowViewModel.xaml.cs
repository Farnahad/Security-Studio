using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.UnShadow.ViewModel;

namespace SecurityStudio.Module.Tool.UnShadow.View
{
    public partial class SsUnShadowView : SsView
    {
        public SsUnShadowView(SsUnShadowViewModel ssUnShadowViewModel)
            : base(ssUnShadowViewModel)
        {
            InitializeComponent();
        }
    }
}
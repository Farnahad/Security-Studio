using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.MD5.ViewModel;

namespace SecurityStudio.Module.Tool.MD5.View
{
    public partial class SsMD5View : SsView
    {
        public SsMD5View(SsMD5ViewModel ssMD5ViewModel)
            : base(ssMD5ViewModel)
        {
            InitializeComponent();
        }
    }
}
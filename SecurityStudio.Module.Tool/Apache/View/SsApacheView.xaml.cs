using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Apache.ViewModel;

namespace SecurityStudio.Module.Tool.Apache.View
{
    public partial class SsApacheView : SsView
    {
        public SsApacheView(SsApacheViewModel ssApacheViewModel)
            : base(ssApacheViewModel)
        {
            InitializeComponent();
        }
    }
}
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.FgDump.ViewModel;

namespace SecurityStudio.Module.Tool.FgDump.View
{
    public partial class SsFgDumpView : SsView
    {
        public SsFgDumpView(SsFgDumpViewModel ssFgDumpViewModel)
            : base(ssFgDumpViewModel)
        {
            InitializeComponent();
        }
    }
}
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Ntlm.ViewModel;

namespace SecurityStudio.Module.Tool.Ntlm.View
{
    public partial class SsNtlmView : SsView
    {
        public SsNtlmView(SsNtlmViewModel ssNtlmViewModel)
            : base(ssNtlmViewModel)
        {
            InitializeComponent();
        }
    }
}
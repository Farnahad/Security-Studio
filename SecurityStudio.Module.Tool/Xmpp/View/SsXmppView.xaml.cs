using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Xmpp.ViewModel;

namespace SecurityStudio.Module.Tool.Xmpp.View
{
    public partial class SsXmppView : SsView
    {
        public SsXmppView(SsXmppViewModel ssXmppViewModel)
            : base(ssXmppViewModel)
        {
            InitializeComponent();
        }
    }
}
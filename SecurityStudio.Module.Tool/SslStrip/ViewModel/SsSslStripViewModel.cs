using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.SslStrip.ViewModel
{
    public class SsSslStripViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "sslstrip";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}
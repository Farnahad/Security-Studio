using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.FgDump.ViewModel
{
    public class SsFgDumpViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "fgdump";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}
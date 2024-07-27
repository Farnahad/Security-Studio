using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.ScadaPass.ViewModel
{
    public class SsScadaPassViewModel : SsViewModel
    {
        public SsCommand SsShowScadaPassCommand { get; set; }
        public SsCommand SsOpenScadaPassCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowScadaPassCommand = new SsCommand(SsShowScadaPass);
            SsOpenScadaPassCommand = new SsCommand(SsOpenScadaPass);
        }

        private void SsShowScadaPass(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenScadaPass(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "SCADAPASS";
            Uri = _uriAddress = "https://github.com/scadastrangelove/SCADAPASS/";
            _utilityTool = new UtilityTool();
        }

        protected override void FillData()
        {
        }

        private string _uri;
        public string Uri
        {
            get => _uri;
            set
            {
                _uri = value;
                OnPropertyChanged();
            }
        }

        public override void Dispose()
        {
        }
    }
}
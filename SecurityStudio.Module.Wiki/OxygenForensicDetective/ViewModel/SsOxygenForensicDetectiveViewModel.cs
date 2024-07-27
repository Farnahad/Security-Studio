using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.OxygenForensicDetective.ViewModel
{
    public class SsOxygenForensicDetectiveViewModel : SsViewModel
    {
        public SsCommand SsShowOxygenForensicDetectiveCommand { get; set; }
        public SsCommand SsOpenOxygenForensicDetectiveCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowOxygenForensicDetectiveCommand = new SsCommand(SsShowOxygenForensicDetective);
            SsOpenOxygenForensicDetectiveCommand = new SsCommand(SsOpenOxygenForensicDetective);
        }

        private void SsShowOxygenForensicDetective(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenOxygenForensicDetective(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Oxygen Forensic Detective";
            Uri = _uriAddress = "https://www.oxygen-forensic.com/en/products/oxygen-forensic-detective/";
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
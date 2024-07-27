using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Attifyos.ViewModel
{
    public class SsAttifyosViewModel : SsViewModel
    {
        public SsCommand SsShowAttifyosCommand { get; set; }
        public SsCommand SsOpenAttifyosCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowAttifyosCommand = new SsCommand(SsShowAttifyos);
            SsOpenAttifyosCommand = new SsCommand(SsOpenAttifyos);
        }

        private void SsShowAttifyos(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenAttifyos(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Attifyos";
            Uri = _uriAddress = "https://www.attify.com/attifyos/";
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
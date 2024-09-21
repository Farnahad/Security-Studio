using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.Log
{
    public interface ILogService : IService
    {
        void Info(string info);
        void Warning(string warning);
        void Error(string error);
        void Error(Exception exception);
    }
}
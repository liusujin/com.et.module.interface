using System.Threading.Tasks;

namespace ETModel
{
    /// <summary>
    /// 初始化接口
    /// </summary>
    public interface IInitialize
    {
        bool Initialize();
        Task<bool> InitializeAsync();
    }
}
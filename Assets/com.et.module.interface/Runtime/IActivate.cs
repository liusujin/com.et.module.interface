using System.Threading.Tasks;

namespace ETModel
{
    /// <summary>
    /// 激活接口
    /// </summary>
    public interface IActivate
    {
        bool Activate();
        Task<bool> ActivateAsync();
    }
}
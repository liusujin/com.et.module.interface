using System.Threading.Tasks;

namespace ETModel
{
    /// <summary>
    /// 失活接口
    /// </summary>
    public interface IDeactivate
    {
        bool Deactivate();
        Task<bool> DeactivateAsync();
    }
}
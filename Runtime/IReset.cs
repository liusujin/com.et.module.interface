using System.Threading.Tasks;

namespace ETModel
{
    /// <summary>
    /// 重置接口
    /// </summary>
    public interface IReset
    {
        bool Reset();
        Task<bool> ResetAsync();
    }
}
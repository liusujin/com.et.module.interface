using System.Threading.Tasks;

namespace ETModel
{
    /// <summary>
    /// 加载接口
    /// </summary>
    public interface ILoad
    {
        bool Load();
        Task<bool> LoadAsync();
    }
}
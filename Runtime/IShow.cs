using System.Threading.Tasks;

namespace ETModel
{
    /// <summary>
    /// 显示接口
    /// </summary>
    public interface IShow
    {
        bool Show();
        Task<bool> ShowAsync();
    }
}
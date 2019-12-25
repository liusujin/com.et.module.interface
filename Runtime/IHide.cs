using System.Threading.Tasks;

namespace ETModel
{
    /// <summary>
    /// 隐藏接口
    /// </summary>
    public interface IHide
    {
        bool Hide();
        Task<bool> HideAsync();
    }
}
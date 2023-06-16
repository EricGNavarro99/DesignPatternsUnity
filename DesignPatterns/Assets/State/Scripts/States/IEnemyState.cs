using System.Threading.Tasks;

namespace Unity.State
{
    public interface IEnemyState
    {
        Task<StateResult> DoAction(object data);
    }
}

using System.Threading.Tasks;

namespace Unity.Commander
{
    public interface ICommand
    {
        Task Execute();
    }
}

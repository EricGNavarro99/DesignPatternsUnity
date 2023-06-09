using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace Unity.Commander
{
    public class LoadSceneCommand : ICommand
    {
        private readonly string sceneName;

        public LoadSceneCommand(string sceneName) => this.sceneName = sceneName;

        public async Task Execute()
        {
            var asyncOperation = SceneManager.LoadSceneAsync(this.sceneName);

            while (!asyncOperation.isDone) await Task.Yield();
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

namespace Unity.Commander
{
    public class Installer : MonoBehaviour
    {
        [SerializeField] private MenuA menuA;
        [SerializeField] private MenuB menuB;

        [SerializeField] private CanvasGroup canvasGroup1;
        [SerializeField] private CanvasGroup canvasGroup2;

        private void Awake()
        {
            var menuACommands = new List<ICommand>
            {
                new CanvasFadeCommand(canvasGroup1, 0, 0.5f),
                new CanvasFadeCommand(canvasGroup2, 1, 0.5f)
            };

            this.menuA.Configure(menuACommands);

            var menuBCommands = new List<ICommand>
            {
                new CanvasFadeCommand(canvasGroup2, 0, 0.5f),
                new CanvasFadeCommand(canvasGroup1, 1, 0.5f)
            };

            this.menuB.Configure(menuBCommands);
        }
    }
}

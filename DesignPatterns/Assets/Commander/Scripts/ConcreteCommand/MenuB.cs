using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unity.Commander
{
    public class MenuB : MonoBehaviour
    {
        [SerializeField] private Button showMenuAButton;

        [SerializeField] private CanvasGroup canvasGroup1;
        [SerializeField] private CanvasGroup canvasGroup2;

        private List<ICommand> showNextMenuCommand = new List<ICommand>();

        private void Awake() => this.showMenuAButton.onClick.AddListener(ShowNextMenu);

        private void ShowNextMenu()
        {
            foreach (var command in this.showNextMenuCommand)
                CommandQueue.Instance.AddCommand(command);
        }

        public void Configure(List<ICommand> showNextMenuCommand)
            => this.showNextMenuCommand = showNextMenuCommand;
    }
}
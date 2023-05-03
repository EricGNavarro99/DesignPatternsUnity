using UnityEngine;
using UnityEngine.UI;

namespace Unity.Mediator
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private Button startGameButton;
        [SerializeField] private Button settingsButton;
        [SerializeField] private Canvas canvas;

        private MenuMediator mediator;

        private void Awake()
        {
            this.startGameButton.onClick.AddListener(() => this.mediator.StartGame());
            this.settingsButton.onClick.AddListener(() => this.mediator.MoveToSettings());
        }

        public void Configure(MenuMediator menuMediator) => this.mediator = menuMediator;

        public void Hide() => this.canvas.gameObject.SetActive(false);

        public void Show() => this.canvas.gameObject.SetActive(true);
    }
}

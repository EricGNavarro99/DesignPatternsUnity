using UnityEngine;
using UnityEngine.UI;

namespace Unity.Mediator
{
    public class SettingsMenu : MonoBehaviour
    {
        [SerializeField] private Button backButton;
        [SerializeField] private Canvas canvas;

        private MenuMediator mediator;

        private void Awake()
        {
            this.backButton.onClick.AddListener(() => this.mediator.MoveToMainMenu());
        }

        public void Configure(MenuMediator menuMediator) => this.mediator = menuMediator;

        public void Hide() => this.canvas.gameObject.SetActive(false);

        public void Show() => this.canvas.gameObject.SetActive(true);
    }
}

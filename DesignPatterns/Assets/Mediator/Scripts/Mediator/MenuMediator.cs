using UnityEngine;

namespace Unity.Mediator
{
    public class MenuMediator : MonoBehaviour
    {
        [SerializeField] private MainMenu mainMenu;
        [SerializeField] private SettingsMenu settingsMenu;

        private void Awake()
        {
            this.mainMenu.Configure(this);
            this.settingsMenu.Configure(this);

            MoveToMainMenu();
        }

        public void StartGame() => print("The game have started!");

        public void MoveToSettings()
        {
            this.mainMenu.Hide();
            this.settingsMenu.Show();
        }

        public void MoveToMainMenu()
        {
            this.mainMenu.Show();
            this.settingsMenu.Hide();
        }
    }
}

using UnityEngine;

namespace Unity.Facade
{
    public class HeroUI : MonoBehaviour
    {
        [SerializeField] private GameObject alliesUI;
        [SerializeField] private GameObject enemiesUI;

        public void ShowAlliesUI() => this.alliesUI.SetActive(true);

        public void HideAlliesUI() => this.alliesUI.SetActive(false);

        public void ShowEnemiesUI() => this.enemiesUI.SetActive(true);

        public void HideEnemiesUI() => this.enemiesUI.SetActive(false);
    }
}

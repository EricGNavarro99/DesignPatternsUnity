using UnityEngine;

namespace Unity.Facade
{
    public class BattleFacade : MonoBehaviour
    {
        [SerializeField] private HeroSpawner heroSpawner;
        [SerializeField] private HeroUI heroUI;

        public void StartBattle()
        {
            this.heroSpawner.SpawnAllies();
            this.heroSpawner.SpawnEnemies();
            this.heroUI.ShowAlliesUI();
            this.heroUI.ShowEnemiesUI();
        }

        public void EndBattle()
        {
            this.heroSpawner.DestroyAllies();
            this.heroSpawner.DestroyEnemies();
            this.heroUI.HideAlliesUI();
            this.heroUI.HideEnemiesUI();
        }
    }
}

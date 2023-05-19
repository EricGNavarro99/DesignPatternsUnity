using System.Collections.Generic;
using UnityEngine;

namespace Unity.Facade
{
    public class HeroSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] alliesToSpawn;

        private List<GameObject> alliesSpawned;

        [SerializeField] private GameObject[] enemiesToSpawn;
        private List<GameObject> enemiesSpawned;

        private void Awake()
        {
            this.alliesSpawned = new List<GameObject>();
            this.enemiesSpawned = new List<GameObject>();
        }

        public void SpawnAllies()
        {
            foreach (var allyToSpawn in this.alliesToSpawn) 
            {
                var allyInstance = Instantiate(allyToSpawn);
                this.alliesSpawned.Add(allyInstance);
            }
        }

        public void DestroyAllies()
        {
            foreach (var allyToDestroy in this.alliesSpawned)
                Destroy(allyToDestroy);

            this.alliesSpawned.Clear();
        }

        public void SpawnEnemies()
        {
            foreach (var enemyToSpawn in this.enemiesToSpawn)
            {
                var enemyInstance = Instantiate(enemyToSpawn);
                this.enemiesSpawned.Add(enemyInstance);
            }
        }

        public void DestroyEnemies()
        {
            foreach (var enemyToDestroy in this.enemiesSpawned)
                Destroy(enemyToDestroy);

            this.enemiesSpawned.Clear();
        }
    }
}

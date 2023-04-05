using UnityEngine;

namespace Unity.FactoryMethod
{
    public class PowerUpSpawner : MonoBehaviour
    {
        [SerializeField] private PowerUpConfiguration powerUpConfiguration;
        private PowerUpFactory powerUpFactory;

        private void Awake()
        {
            this.powerUpFactory = new PowerUpFactory(Instantiate(this.powerUpConfiguration));
        }

        public void SpawnPowerUp(string id) => this.powerUpFactory.Create(id);
    }
}
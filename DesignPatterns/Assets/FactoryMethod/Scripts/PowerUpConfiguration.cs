using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FactoryMethod
{
    [CreateAssetMenu(menuName = "Custom/Power up configuration")]
    public class PowerUpConfiguration : ScriptableObject 
    {
        [SerializeField] private PowerUp[] powerUps;
        private Dictionary<string, PowerUp> idToPowerUp;

        private void Awake()
        {
            this.idToPowerUp = new Dictionary<string, PowerUp>();

            foreach (var powerUp in this.powerUps)
                this.idToPowerUp.Add(powerUp.Id, powerUp);
        }

        public PowerUp GetPowerUpPrefabById(string id)
        {
            if (!this.idToPowerUp.TryGetValue(id, out var powerUp))
                throw new Exception($"Power up with id {id} does not exist.");

            return powerUp;
        }
    }
}
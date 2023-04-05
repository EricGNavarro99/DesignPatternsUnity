namespace Unity.FactoryMethod
{
    public class PowerUpFactory
    {
        private readonly PowerUpConfiguration powerUpConfiguration;

        public PowerUpFactory(PowerUpConfiguration powerUpConfiguration)
        {
            this.powerUpConfiguration = powerUpConfiguration;
        }

        public PowerUp Create(string id)
        {
            var powerUp = this.powerUpConfiguration.GetPowerUpPrefabById(id);

            return UnityEngine.Object.Instantiate(powerUp);
        }
    }
}
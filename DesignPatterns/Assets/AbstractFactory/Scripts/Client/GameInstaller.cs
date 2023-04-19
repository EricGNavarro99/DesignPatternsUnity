using UnityEngine;

namespace Unity.AbstractFactory
{
    public class GameInstaller : MonoBehaviour
    {
        [SerializeField] private HeroesConfiguration heroesConfiguration;
        [SerializeField] private WeaponsConfiguration weaponsConfiguration;
        [SerializeField] private WeaponsConfiguration heavyWeaponsConfiguration;

        private Consumer consumer;

        private BattleFactory battleFactory;
        private BattleFactory heavyWeaponsBattleFactory;

        private void Start()
        {
            var heroFactory = new HeroFactory(Instantiate(this.heroesConfiguration));
            var weaponFactory = new WeaponFactory(Instantiate(this.weaponsConfiguration));
            var heavyWeaponFactory = new WeaponFactory(Instantiate(this.heavyWeaponsConfiguration));

            var consumerGameObject = new GameObject();
            this.consumer = consumerGameObject.AddComponent<Consumer>();

            this.battleFactory = new BattleFactory(heroFactory, weaponFactory);
            this.heavyWeaponsBattleFactory = new BattleFactory(heroFactory, heavyWeaponFactory);

            SelectBattleFactory(this.battleFactory);
        }

        private void SelectBattleFactory(BattleFactory battleFactory) => this.consumer.Configure(battleFactory);
    }
}

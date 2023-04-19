namespace Unity.AbstractFactory
{
    public class BattleFactory
    {
        private readonly HeroFactory heroFactory;
        private readonly WeaponFactory weaponFactory;

        public BattleFactory(HeroFactory heroFactory, WeaponFactory weaponFactory)
        {
            this.heroFactory = heroFactory;
            this.weaponFactory = weaponFactory;
        }

        public Hero CreateHero(string id) => this.heroFactory.Create(id);

        public Weapon CreateWeapon(string id) => this.weaponFactory.Create(id);
    }
}

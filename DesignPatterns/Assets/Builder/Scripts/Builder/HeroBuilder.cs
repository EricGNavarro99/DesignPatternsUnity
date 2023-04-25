using UnityEngine;
using UnityEngine.Assertions;

namespace Unity.Builder
{
    public class HeroBuilder
    {
        private Hero hero;

        private Weapon weapon;
        private Magic magic;

        public HeroBuilder WithWeapon(Weapon weapon)
        {
            this.weapon = weapon;
            return this;
        }

        public HeroBuilder WithMagic(Magic magic)
        {
            this.magic = magic;
            return this;
        }

        public HeroBuilder FromHeroPrefab(Hero hero)
        {
            this.hero = hero;
            return this;
        }

        public Hero Build()
        {
            Assert.IsNotNull(this.hero, "Hero's prefab cannot be null");

            var hero = Object.Instantiate(this.hero);
            var weapon = Object.Instantiate(this.weapon, hero.transform);
            var magic = Object.Instantiate(this.magic, hero.transform);

            hero.SetComponents(weapon, magic);

            return hero;
        }
    }
}

namespace Unity.AbstractFactory
{
    public class HeroFactory
    {
        private readonly HeroesConfiguration heroesConfiguration;

        public HeroFactory(HeroesConfiguration heroesConfiguration)
        {
            this.heroesConfiguration = heroesConfiguration;
        }

        public Hero Create(string id)
        {
            var hero = this.heroesConfiguration.GetHeroPrefabById(id);
            return UnityEngine.Object.Instantiate(hero);
        }
    }
}

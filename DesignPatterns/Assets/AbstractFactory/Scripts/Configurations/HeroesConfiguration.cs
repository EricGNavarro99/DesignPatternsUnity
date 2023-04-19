using System.Collections.Generic;
using UnityEngine;

namespace Unity.AbstractFactory
{
    [CreateAssetMenu(menuName = "Custom/Heroes Configuration")]
    public class HeroesConfiguration : ScriptableObject
    {
        [SerializeField] private Hero[] heroes;
        private Dictionary<string, Hero> idToHero;

        private void Awake()
        {
            this.idToHero = new Dictionary<string, Hero>();

            foreach(var hero in this.heroes)
                this.idToHero.Add(hero.Id, hero);
        }

        public Hero GetHeroPrefabById(string id)
        {
            if (!this.idToHero.TryGetValue(id, out var hero))
                throw new System.Exception($"Hero with id {id} does not exist");

            return hero;
        }
    }
}

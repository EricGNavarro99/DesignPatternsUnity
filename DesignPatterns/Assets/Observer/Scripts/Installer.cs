using UnityEngine;

namespace Unity.Observer
{
    public class Installer : MonoBehaviour
    {
        [SerializeField] private HealthView healthView;
        private Hero hero;

        private void Awake()
        {
            this.hero = new Hero();
            this.healthView.Configure(this.hero);
        }

        public void ApplyDamage() => this.hero.ApplyDamage(10);
    }
}

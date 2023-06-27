using UnityEngine;
using TMPro;

namespace Unity.Observer
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI health;

        public void Configure(IHero hero) => hero.OnHealthUpdated += Updated;

        private void Updated(int health) => this.health.SetText(health.ToString());
    }
}

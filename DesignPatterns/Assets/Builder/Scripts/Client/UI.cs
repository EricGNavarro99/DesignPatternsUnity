using UnityEngine;
using UnityEngine.UI;

namespace Unity.Builder
{
    public class UI : MonoBehaviour
    {
        [SerializeField] private Weapon sword;
        [SerializeField] private Weapon lance;
        [SerializeField] private Magic pyromancy;
        [SerializeField] private Magic miracle;

        [SerializeField] private Hero hero;

        [SerializeField] private Button swordButton;
        [SerializeField] private Button lanceButton;
        [SerializeField] private Button piromancyButton;
        [SerializeField] private Button miracleButton;

        [SerializeField] private Button buildButton;

        private HeroBuilder heroBuilder;
        private Hero heroInstance;


        private void Awake()
        {
            this.heroBuilder = new HeroBuilder();
            this.heroBuilder.FromHeroPrefab(this.hero);

            this.swordButton.onClick.AddListener(SwordButtonPressed);
            this.lanceButton.onClick.AddListener(LanceButtonPressed);
            this.piromancyButton.onClick.AddListener(PiromancyButtonPressed);
            this.miracleButton.onClick.AddListener(MiracleButtonPressed);

            this.buildButton.onClick.AddListener(BuildButtonPressed);
        }

        private void SwordButtonPressed() => heroBuilder.WithWeapon(sword);

        private void LanceButtonPressed() => heroBuilder.WithWeapon(lance);

        private void PiromancyButtonPressed() => heroBuilder.WithMagic(pyromancy);

        private void MiracleButtonPressed() => heroBuilder.WithMagic(miracle);

        private void BuildButtonPressed()
        {
            if (this.heroInstance != null) Destroy(this.heroInstance.gameObject);

            this.heroInstance = heroBuilder.Build();
        }
    }
}

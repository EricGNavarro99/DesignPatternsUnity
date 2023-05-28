using UnityEngine;
using TMPro;

namespace Unity.Decorator
{
    public class DamageReceiver : MonoBehaviour, IDamageReceiver
    {
        [SerializeField] private TextMeshProUGUI[] damageTexts;
        private int lastTextUsed;

        private void Awake()
        {
            foreach (var damageText in this.damageTexts)
                damageText.SetText(string.Empty);
        }

        public void ReceiveDamage(int damage, Color color)
        {
            var textIndex = GetTextIndexToUse();

            this.damageTexts[textIndex].SetText(damage.ToString());
            this.damageTexts[textIndex].color = color;

            this.lastTextUsed = textIndex;
        }

        private int GetTextIndexToUse() => (this.lastTextUsed + 1) % this.damageTexts.Length;
    }
}

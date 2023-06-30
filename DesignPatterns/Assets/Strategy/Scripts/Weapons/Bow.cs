using UnityEngine;

namespace Unity.Strategy
{
    public class Bow : MonoBehaviour, Weapon
    {
        [SerializeField] private GameObject arrowPrefab;
        [SerializeField] private Transform spawnReference;

        public void Attack()
        {
            var arrow = Instantiate(this.arrowPrefab, this.spawnReference.position, this.spawnReference.rotation);
        }
    }
}
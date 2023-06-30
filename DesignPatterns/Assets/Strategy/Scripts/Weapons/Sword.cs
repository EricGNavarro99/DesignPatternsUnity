using UnityEngine;

namespace Unity.Strategy
{
    public class Sword : MonoBehaviour, Weapon
    {
        [SerializeField] private Transform damageZoneCenter;
        [SerializeField] private float damageZoneRadius;
        private readonly Collider2D[] hitColliders = new Collider2D[10];

        public void Attack()
        {
            var size = Physics2D.OverlapCircleNonAlloc(this.damageZoneCenter.position, this.damageZoneRadius, this.hitColliders);

            for (var a = 0; a < size; a++)
            {
                var hitCollider = this.hitColliders[a];
                var hero = hitCollider.GetComponent<Damageable>();
                hero?.DoDamage(10);
            }
        }
    }
}

using UnityEngine;

namespace Unity.Strategy
{
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class Arrow : MonoBehaviour
    {
        [SerializeField] private float speed;

        private void Awake() 
            => gameObject.GetComponent<Rigidbody2D>().velocity = this.transform.right * this.speed;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var hero = collision.GetComponent<Damageable>();
            hero?.DoDamage(10);

            Destroy(this.gameObject);
        }
    }
}

using UnityEngine;

namespace Unity.AbstractFactory
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] protected string id;

        public string Id => this.id;
    }
}

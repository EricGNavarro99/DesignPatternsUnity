using UnityEngine;

namespace Unity.AbstractFactory
{
    public abstract class Hero : MonoBehaviour
    {
        [SerializeField] protected string id;

        public string Id => this.id;
    }
}

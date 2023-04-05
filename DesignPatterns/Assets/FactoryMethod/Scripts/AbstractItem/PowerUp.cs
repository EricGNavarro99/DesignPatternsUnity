using UnityEngine;

namespace Unity.FactoryMethod
{
    public abstract class PowerUp : MonoBehaviour
    {
        [SerializeField] private string id;
        public string Id { get => this.id; }
    }
}
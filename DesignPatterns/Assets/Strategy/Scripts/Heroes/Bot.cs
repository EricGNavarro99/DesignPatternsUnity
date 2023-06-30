using UnityEngine;

namespace Unity.Strategy
{
    public class Bot : MonoBehaviour, Damageable
    {
        public void DoDamage(int damage) => print("Damage received");
    }
}
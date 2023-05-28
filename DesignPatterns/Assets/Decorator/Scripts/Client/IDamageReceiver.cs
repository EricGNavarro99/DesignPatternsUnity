using UnityEngine;

namespace Unity.Decorator
{
    public interface IDamageReceiver
    {
        void ReceiveDamage(int damage, Color color);
    }
}

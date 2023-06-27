using System;

namespace Unity.Observer
{
    public interface IHero
    {
        event Action<int> OnHealthUpdated;
    }
}

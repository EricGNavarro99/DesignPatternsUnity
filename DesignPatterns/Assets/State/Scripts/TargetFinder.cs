using UnityEngine;

namespace Unity.State
{
    public class TargetFinder : ITargetFinder
    {
        public static TargetFinder Instance => instance ?? (instance = new TargetFinder());
        public static TargetFinder instance;

        public Enemy[] FindTargets() => Object.FindObjectsOfType<Enemy>();
    }
}

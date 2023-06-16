using System.Threading.Tasks;

namespace Unity.State
{
    public class FindTargetState : IEnemyState
    {
        private readonly ITargetFinder targetFinder;
        private readonly Enemy enemy;
        private readonly float sqrMaxDistance;

        public FindTargetState (Enemy enemy, float visionRange, ITargetFinder targetFinder)
        {
            this.enemy = enemy;
            this.sqrMaxDistance = visionRange * visionRange;
            this.targetFinder = targetFinder;
        }

        public Task<StateResult> DoAction(object date)
        {
            var targets = this.targetFinder.FindTargets();

            foreach (var target in targets)
            {
                if (target == this.enemy) continue;

                var sqrDistanceToTheTarget = (target.CurrentPosition - this.enemy.CurrentPosition).sqrMagnitude;
                if (sqrDistanceToTheTarget > this.sqrMaxDistance) continue;

                return Task.FromResult(new StateResult(EnemyStatesConfiguration.MovingToTargetState, target));
            }

            return Task.FromResult(new StateResult(EnemyStatesConfiguration.IdleState));
        }
    }
}

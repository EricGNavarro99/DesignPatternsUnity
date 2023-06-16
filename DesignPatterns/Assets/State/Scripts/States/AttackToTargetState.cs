using System.Threading.Tasks;
using UnityEngine.Assertions;

namespace Unity.State
{
    public class AttackToTargetState : IEnemyState
    {
        private readonly float damageToApply;

        public AttackToTargetState(float damageToApply) => this.damageToApply = damageToApply;
        public Task<StateResult> DoAction(object data)
        {
            var target = data as Enemy;
            Assert.IsNotNull(target);

            target.DoDamage(this.damageToApply);
            return Task.FromResult(new StateResult(EnemyStatesConfiguration.IdleState));
        }
    }
}

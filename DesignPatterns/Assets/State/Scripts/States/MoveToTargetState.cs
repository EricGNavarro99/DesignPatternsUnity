using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Assertions;

namespace Unity.State
{
    public class MoveToTargetState : IEnemyState
    {
        private readonly Enemy enemy;
        private readonly float sqrMinDistanceToAttack;
        private readonly float movementSpeed;

        public MoveToTargetState(Enemy enemy, float minDistanceToAttack, float movementSpeed)
        {
            this.enemy = enemy;
            this.movementSpeed = movementSpeed;
            this.sqrMinDistanceToAttack = minDistanceToAttack * minDistanceToAttack;
        }

        public async Task<StateResult> DoAction(object data)
        {
            var target = data as Enemy;
            Assert.IsNotNull(target);

            var distanceToTheTarget = (target.CurrentPosition - enemy.CurrentPosition);

            do
            {
                this.enemy.transform.Translate(distanceToTheTarget.normalized * this.movementSpeed * Time.deltaTime);

                await Task.Yield();

                distanceToTheTarget = (target.CurrentPosition - this.enemy.CurrentPosition);
            } while(distanceToTheTarget.sqrMagnitude > this.sqrMinDistanceToAttack);

            return new StateResult(EnemyStatesConfiguration.AttackingTargetState, target);
        }
    }
}

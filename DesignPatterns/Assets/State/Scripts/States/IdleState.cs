using System;
using System.Threading.Tasks;

namespace Unity.State
{
    public class IdleState : IEnemyState
    {
        private readonly float secondsToWait;

        public IdleState(float secondsToWait) => this.secondsToWait = secondsToWait;

        public async Task<StateResult> DoAction(object data)
        {
            await Task.Delay(TimeSpan.FromSeconds(this.secondsToWait));
            return new StateResult(EnemyStatesConfiguration.FindTargetState);
        }
    }
}

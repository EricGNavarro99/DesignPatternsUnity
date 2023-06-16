using UnityEngine;

namespace Unity.State
{
    public class Enemy : MonoBehaviour, ITarget
    {
        public Vector3 CurrentPosition => transform.position;

        private EnemyStatesConfiguration enemyStatesConfiguration;
        private TargetFinder targetsFinder;

        private void Awake()
        {
            this.enemyStatesConfiguration = new EnemyStatesConfiguration();

            this.enemyStatesConfiguration.AddInitialState(EnemyStatesConfiguration.IdleState, new IdleState(2.0f));
            this.enemyStatesConfiguration.AddState(EnemyStatesConfiguration.FindTargetState, new FindTargetState(this, 20, TargetFinder.Instance));
            this.enemyStatesConfiguration.AddState(EnemyStatesConfiguration.MovingToTargetState, new MoveToTargetState(this, 0.5f, 2));
            this.enemyStatesConfiguration.AddState(EnemyStatesConfiguration.AttackingTargetState, new AttackToTargetState(2));
        }

        private void Start() => StartState(this.enemyStatesConfiguration.GetInitialState());

        private async void StartState(IEnemyState state, object data = null)
        {
            while(true)
            {
                var resultData = await state.DoAction(data);
                var nextState = this.enemyStatesConfiguration.GetState(resultData.nextStateId);

                state = nextState;
                data = resultData.resultData;
            }
        }

        public void DoDamage(float damageToApply) => print("Receiving damage!");
    }
}

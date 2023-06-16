using System.Collections.Generic;
using UnityEngine.Assertions;

namespace Unity.State
{
    public class EnemyStatesConfiguration
    {
        private int initialState;

        public const int IdleState = 0;
        public const int FindTargetState = 1;
        public const int MovingToTargetState = 2;
        public const int AttackingTargetState = 3;

        private readonly Dictionary<int, IEnemyState> states;

        public EnemyStatesConfiguration() => this.states = new Dictionary<int, IEnemyState>();

        public void AddInitialState(int id, IEnemyState state)
        {
            this.states.Add(id, state);
            this.initialState = id;
        }

        public void AddState(int id, IEnemyState state) => this.states.Add(id, state);

        public IEnemyState GetState(int stateId)
        {
            Assert.IsTrue(this.states.ContainsKey(stateId), $"State with id {stateId} do not exist.");
            return this.states[stateId];
        }

        public IEnemyState GetInitialState() => GetState(initialState);
    }
}

using UnityEngine;

namespace Unity.AbstractFactory
{
    public class Consumer : MonoBehaviour
    {
        private BattleFactory currentBattleFactory;

        public void Configure(BattleFactory battleFactory)
        {
            this.currentBattleFactory = battleFactory;
        }

        private void Update()
        {
            /* 
             * This is an example of how to call the 'prefabs', but is breaking 'Open close' solid principle.
             * It is better not to do it this way.
             */

            if (Input.GetKeyDown(KeyCode.Alpha1))
                currentBattleFactory.CreateHero("warrior");

            if (Input.GetKeyDown(KeyCode.Alpha2))
                currentBattleFactory.CreateHero("paladin");

            if (Input.GetKeyDown(KeyCode.Alpha3))
                currentBattleFactory.CreateWeapon("sword");

            if (Input.GetKeyDown(KeyCode.Alpha4))
                currentBattleFactory.CreateWeapon("shield");

        }
    }
}

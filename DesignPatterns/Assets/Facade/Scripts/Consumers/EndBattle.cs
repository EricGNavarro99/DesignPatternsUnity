using UnityEngine;

namespace Unity.Facade
{
    public class EndBattle : MonoBehaviour
    {
        [SerializeField] private BattleFacade battleFacade;

        public void EB() => this.battleFacade.EndBattle();
    }
}
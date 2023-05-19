using UnityEngine;

namespace Unity.Facade
{
    public class StartBattle : MonoBehaviour
    {
        [SerializeField] private BattleFacade battleFacade;

        public void SB() => this.battleFacade.StartBattle();
    }
}
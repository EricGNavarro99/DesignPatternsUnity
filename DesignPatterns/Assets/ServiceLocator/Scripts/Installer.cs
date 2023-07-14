using UnityEngine;

namespace Unity.ServiceLocator
{
    public class Installer : MonoBehaviour
    {
        private void Awake()
            => ServiceLocator.Instance.RegisterService<IDataSaver>(new PlayerPrefsAdapter());
    }
}

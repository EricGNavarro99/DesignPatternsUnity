using UnityEngine;

namespace Unity.ServiceLocator
{
    public class Consumer : MonoBehaviour
    {
        private bool registred = false;

        public void Register()
        {
            if (registred) return;

            var dataSaver = ServiceLocator.Instance.GetService<IDataSaver>();
            dataSaver.SetString("key", "test");

            registred = true;
        }

        public void PrintRegister()
        {
            if (!registred) return;

            var dataSaver = ServiceLocator.Instance.GetService<IDataSaver>();
            var text = dataSaver.GetString("key");

            print(text);
        }
    }
}

using UnityEngine;

namespace Unity.Singleton
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static bool shuttingDown = false;
        private static object lockObject = new object();
        private static T instance;

        public static T Instance
        {
            get
            {
                if (shuttingDown)
                {
                    Debug.LogWarning($"Singleton instance {typeof(T)} already destroyed.");
                    return null;
                }

                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = (T)FindObjectOfType(typeof(T));

                        if (instance == null) 
                        {
                            var singletonObject = new GameObject();
                            instance = singletonObject.AddComponent<T>();
                            singletonObject.name = $"{typeof(T).ToString()} (Singleton).";

                            DontDestroyOnLoad(singletonObject);
                        }
                    }

                    return instance;
                }
            }
            
        }

        private void OnApplicationQuit() => shuttingDown = true;

        private void OnDestroy() => shuttingDown = true;
    }
}
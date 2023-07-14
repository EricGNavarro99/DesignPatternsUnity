using UnityEngine;

namespace Unity.ServiceLocator
{
    public class PlayerPrefsAdapter : IDataSaver
    {
        public void SetString(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
            PlayerPrefs.Save();
        }

        public string GetString(string key, string defaultValue = default) 
            => PlayerPrefs.GetString(key, defaultValue);

        public void SetInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
            PlayerPrefs.Save();
        }

        public int GetInt(string key, int defaultValue = default)
            => PlayerPrefs.GetInt(key, defaultValue);
    }
}

namespace Unity.ServiceLocator
{
    public interface IDataSaver
    {
        void SetString(string key, string value);

        string GetString(string key, string value = default);

        void SetInt(string key, int value);

        int GetInt(string key, int defaultValue = default);
    }
}

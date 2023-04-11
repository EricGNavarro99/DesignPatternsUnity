using UnityEngine;

namespace Unity.Singleton
{
    public class MessageCreator : Singleton<MessageCreator>
    {
        public void PrintMessage(string message) => print(message);

        public void PrintDebugWarningMessage(string message) => Debug.LogWarning(message);

        public void PrintDebugErrorMessage(string message) => Debug.LogError(message);
    }
}

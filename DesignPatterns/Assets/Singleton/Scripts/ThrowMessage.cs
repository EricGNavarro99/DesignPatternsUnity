using UnityEngine;

namespace Unity.Singleton
{
    public enum MessageType { normal, warning, error }

    public class ThrowMessage : MonoBehaviour
    {
        public string message;
        [Space]
        public MessageType messageType;

        private void OnEnable()
        {
            switch (messageType)
            {
                case MessageType.normal:
                    MessageCreator.Instance.PrintMessage(message);
                    break;

                case MessageType.warning:
                    MessageCreator.Instance.PrintDebugWarningMessage(message);
                    break;

                case MessageType.error:
                    MessageCreator.Instance.PrintDebugErrorMessage(message);
                    break;
            }
        }
    }
}
using UnityEngine;

namespace UwU.Unity.Logger
{
    public class UnityLogger : UwU.Logger.ILogger
    {
        public void Error(object message)
        {
            Debug.LogWarning(message);
        }

        public void Trace(object message)
        {
            Debug.Log($"<color=cyan>{message}</color>");
        }

        public void Warn(object message)
        {
            Debug.LogWarning(message);
        }
    }
}
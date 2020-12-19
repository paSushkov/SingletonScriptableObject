using UnityEngine;

namespace Sushkov.SingletonScriptableObject
{
    public abstract class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
    {
        private static T _instance = null;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    var results = Resources.FindObjectsOfTypeAll<T>();
                    if (results.Length == 0)
                    {
                        Debug.LogError($"SingletonScriptableObject: results lenght is 0 of {typeof(T)}");
                        return null;
                    }

                    if (results.Length > 1)
                    {
                        Debug.LogError($"SingletonScriptableObject: results lenght is greater than 1 of {typeof(T)}");
                        return null;
                    }

                    _instance = results[0];
                    _instance.hideFlags = HideFlags.DontUnloadUnusedAsset;
                }

                return _instance;
            }
        }
    }
}
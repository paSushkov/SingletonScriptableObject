using UnityEngine;

namespace Sushkov.SingletonScriptableObject
{
    [CreateAssetMenu(menuName =  "Sushkov/SingletonScriptableObject/MasterManager")]
    public class MasterManager : SingletonScriptableObject<MasterManager>
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void FirstInitialize()
        {
            Debug.Log("Master manger initialized");
        }
    }
}
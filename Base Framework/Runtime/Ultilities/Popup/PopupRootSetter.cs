using UnityEngine;

namespace BaXoai
{
    public class PopupRootSetter : MonoBehaviour
    {
        private void Awake()
        {
            PopupManager.SetRoot(transform);
        }
    }
}

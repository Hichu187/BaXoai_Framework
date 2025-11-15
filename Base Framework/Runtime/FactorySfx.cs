using UnityEngine;

namespace BaXoai
{
    public class FactorySfx : ScriptableObjectSingleton<FactorySfx>
    {
        [SerializeField] private AudioConfig _click;

        public static AudioConfig click => instance._click;
    }
}

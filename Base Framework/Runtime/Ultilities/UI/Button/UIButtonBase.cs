using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace BaXoai
{
    public class UIButtonBase : MonoCached
    {
        [SerializeField] private TextMeshProUGUI _label;
        public TextMeshProUGUI Label => _label;

        private Button _button;
        public Button Button
        {
            get
            {
                if (_button == null)
                    _button = GetComponentInChildren<Button>();
                return _button;
            }
        }

        protected virtual void Awake()
        {
            Button.onClick.AddListener(Button_OnClick);
        }

        public virtual void Button_OnClick()
        {
        }

        public void SetText(string text)
        {
            if (_label == null)
            {
                Debug.LogWarning($"[{nameof(UIButtonBase)}] {name}: _label chưa được gán, không thể SetText.", this);
                return;
            }

            _label.text = text;
        }
    }
}

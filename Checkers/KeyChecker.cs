using UnityEngine;
using Trell.Interaction.Core;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace Trell.Interaction.Checkers
{
    [AddComponentMenu("KeyCheck for new InputSystem")]
    public class KeyChecker : MonoBehaviour, IChecker
    {
        [SerializeField] private KeyCode _keyCode;

        private KeyControl _keyControl;

        private void Start()
        {
            _keyControl = Keyboard.current.FindKeyOnCurrentKeyboardLayout(_keyCode.ToString());
        }

        public bool Check()
        {
            return _keyControl.wasPressedThisFrame;      
        }
    }
}
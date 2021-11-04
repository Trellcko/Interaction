using UnityEngine;
using Trell.Interaction.Core;

namespace Trell.Interaction.Checkers
{
    public class ToggleChecker : MonoBehaviour, IChecker
    {
        [SerializeField] private bool _toggled;
        public bool Check()
        {
            return _toggled;
        }
    }
}
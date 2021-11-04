using UnityEngine;
using Trell.Interaction.Core;
using System;

namespace Trell.Interaction.Actions
{
    //Wrapper for Action to use in ConsistentlyActionInfo
    public class DelayAction : MonoBehaviour, IDelayAction
    {
        [SerializeField] private IAction _action;

        public event Action Completed;

        public void Do()
        {
            _action.Do();
            Completed?.Invoke();
        }
    }
}
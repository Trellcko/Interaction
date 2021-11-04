using System;
using Trell.Interaction.Core;
using Trell.Interaction.Utils;
using UnityEngine;

namespace Trell.Interaction.Actions
{
    public class WaitingDelayAction : MonoBehaviour, IDelayAction
    {
        [SerializeField] private Waiter _waiter;

        [SerializeField] private IAction _action;

        public event Action Completed;

        public void Do()
        {
            _waiter.Run(() => 
            {
                _action.Do();
                Completed?.Invoke(); 
                }
            );
        }
    }
}
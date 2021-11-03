using System;
using Trell.Interaction.Core;
using Trell.Interaction.Utils;
using UnityEngine;

namespace Trell.Interaction.Actions
{
    public class RemoveGameobjectDelayAction : MonoBehaviour, IDelayAction
    {
        [SerializeField] Waiter _waiter;

        [SerializeField] GameObject _target;

        public event Action Completed;

        public void Do()
        {
            _waiter.Run(() => 
            { 
                Destroy(_target);
                Completed?.Invoke(); 
                }
            );
        }
    }
}
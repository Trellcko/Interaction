using System.Collections.Generic;
using Trell.Interaction.Core;
using UnityEngine;

namespace Trell.Interaction.InteractActions
{
    public class ÑonsistentlyActionsInfo : MonoBehaviour, IInteractionActionsInfo
    {
        [SerializeField] private Queue<IDelayAction> _actions;
        [SerializeField] private List<IChecker> _checkers;

        public bool TryDoActions()
        {
            foreach (var checer in _checkers)
            {
                if (checer.Check() == false)
                {
                    return false;
                }
            }

            DoNext();

            return true;
        }

        private void DoNext()
        {
            if (_actions.Count == 0)
            {
                return;
            }

            var action = _actions.Dequeue();
            action.Completed += DoNext;
            action.Do();
        }
    }
}
using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using Trell.Interaction.Core;

namespace Trell.Interaction.InteractActions
{
    public class InteractionParallelActionsInfo : SerializedMonoBehaviour, IInteractionActionsInfo
    {
        [SerializeField] private List<IAction> _actions;
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
            foreach (var action in _actions)
            {
                action.Do();
            }
            return true;
        }
    }
}
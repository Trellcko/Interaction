using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

namespace Trell.Interaction
{
    public class Interactable : SerializedMonoBehaviour
    {
        [SerializeField] private List<ActionsInfo> _interactActionsInfo;

        [SerializeField] private List<ActionsInfo> _disableActionsInfo;

        [SerializeField] private List<ActionsInfo> _enableActionsInfo;

        private bool _isInteracting = false;

        public void Update()
        {
            if (_isInteracting)
            {
                TryDoActions(_interactActionsInfo);
            }
        }

        public void EnableInteraction()
        {
            _isInteracting = true;
            TryDoActions(_enableActionsInfo);
        }

        public void DisableInteraction()
        {
            _isInteracting = false;
            TryDoActions(_disableActionsInfo);


        }

        public void TryDoActions(List<ActionsInfo> interactionInfo)
        {
            foreach (var interactInfo in interactionInfo)
            {
                interactInfo.TryDoActions();
            }
        }

    }
}
using UnityEngine;

namespace Trell.Interaction.Interacting
{

    [RequireComponent(typeof(Collider2D))]
    public class Trigger2dInteracting : MonoBehaviour
    {
        private Interactable _interactable;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(TryGetComponent(out _interactable))
            {
                _interactable.EnableInteraction();
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if(_interactable)
            {
                _interactable.DisableInteraction();
                _interactable = null;
            }
        }
    }
}
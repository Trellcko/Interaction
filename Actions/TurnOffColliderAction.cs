using UnityEngine;
using Trell.Interaction.Core;

namespace Trell.Interaction.Actions
{
    public class TurnOffColliderAction : MonoBehaviour, IAction
    {
        [SerializeField] private Collider2D _collider2D;

        public void Do()
        {
            _collider2D.enabled = false;
        }
    }
}
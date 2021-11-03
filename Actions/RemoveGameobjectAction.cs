using UnityEngine;
using Trell.Interaction.Core;

namespace Trell.Interaction.Actions
{
    public class RemoveGameobjectAction : MonoBehaviour, IAction
    {
        [SerializeField] private GameObject _target;


        public void Do()
        {
            Destroy(_target);
        }
    }
}
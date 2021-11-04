using UnityEngine;
using Trell.Interaction.Core;

namespace Trell.Interaction
{
    public class DisableGameobjectAction : MonoBehaviour, IAction 
    {
        [SerializeField] private GameObject _gameObject;

        public void Do()
        {
            _gameObject.SetActive(false);
        }
    }

}
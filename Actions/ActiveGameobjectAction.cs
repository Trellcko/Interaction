using UnityEngine;
using Trell.Interaction.Core;
using System;

namespace Trell.Interaction
{
    public class ActiveGameobjectAction : MonoBehaviour, IAction 
    {
        [SerializeField] private GameObject _gameObject;

        public void Do()
        {
            _gameObject.SetActive(true);
        }
    }

}
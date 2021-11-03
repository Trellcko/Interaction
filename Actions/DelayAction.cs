using Sirenix.OdinInspector;
using System.Collections;
using Trell.Interaction.Core;
using UnityEngine;

namespace Trell.Core
{
    public class DelayAction : SerializedMonoBehaviour, IAction
    {
        [SerializeField] private IAction _action;
        [SerializeField] private float _duration;

        public void Do()
        {
            StartCoroutine(DoCorun());
        }

        private IEnumerator DoCorun()
        {
            yield return new WaitForSeconds(_duration);
            _action.Do();
        }
    }
}
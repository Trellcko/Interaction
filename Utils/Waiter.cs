using System;
using System.Collections;
using UnityEngine;

namespace Trell.Interaction.Utils
{
    public class Waiter : MonoBehaviour
    {
        [SerializeField] private float _duration;

        public void Run(Action action)
        {
            StartCoroutine(Corun(action));
        }

        private IEnumerator Corun(Action action)
        {
            yield return new WaitForSeconds(_duration);
            action?.Invoke();
        }
    }
}
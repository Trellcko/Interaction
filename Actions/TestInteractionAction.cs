using Trell.Interaction.Core;
using UnityEngine;

namespace Trell.Interaction.Actions
{
    public class TestInteractionAction : MonoBehaviour, IAction
    {
        public void Do()
        {
            Debug.Log("Test Interaction");
        }
    }
}
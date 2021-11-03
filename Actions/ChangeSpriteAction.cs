using UnityEngine;
using Trell.Interaction.Core;

namespace Trell.Interaction.Actions
{
    public class ChangeSpriteAction : MonoBehaviour, IAction
    {
        [SerializeField] private SpriteRenderer _target;
        [SerializeField] private Sprite _newSprite;


        public void Do()
        {
            _target.sprite = _newSprite;
        }

    }
}
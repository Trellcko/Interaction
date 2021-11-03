using UnityEngine;
using Trell.Interaction.Core;

public class TeleportAction : MonoBehaviour, IAction
{
    [SerializeField] private Transform _to;

    [SerializeField] private Transform _target;

    public void Do()
    {
        _target.position = _to.position;
    }
}

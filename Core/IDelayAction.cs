using System;
using UnityEngine;

namespace Trell.Interaction.Core
{
    public interface IDelayAction : IAction
    {
        event Action Completed;
    }
}
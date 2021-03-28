using Abstraction_Architecture;
using UnityEngine;

namespace GameFolders.Scripts.Abstraction_Architecture
{
    public class FireInputStateProvider : IStateProvider
    {
        public bool IsFıre => Input.GetMouseButtonDown(0);
    }
}
using Abstraction_Architecture;
using UnityEngine;

namespace GameFolders.Scripts.Abstraction_Architecture
{
    public class MovementInputStateProvider : IStateProvider
    {
        public virtual float Horizontal => Input.GetAxis("Horizontal");
        public virtual float Vertical => Input.GetAxis("Vertical");
        
    }
}
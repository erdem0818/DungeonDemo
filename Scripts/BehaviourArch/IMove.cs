using UnityEngine;

namespace GameFolders.Scripts.BehaviourArch
{
    public interface IMove
    {
        //Components and fields for moving
        Rigidbody GetRigidbody();
        float GetSpeed();
    }
}
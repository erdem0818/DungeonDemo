using UnityEngine;

namespace GameFolders.Scripts.State_Machine_Trys.FSM_Enes
{
    public class IdleState : MonoBehaviour , StateManager.IState
    {
        public void OnEnter()
        {
            Debug.Log("Idle Entered");
        }

        public void OnUpdate()
        {
            print("Idle Updating");
        }

        public void OnExit()
        {
            print("Idle Exit");
        }
    }
}

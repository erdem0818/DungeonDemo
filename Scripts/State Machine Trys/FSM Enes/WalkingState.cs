using UnityEngine;

namespace GameFolders.Scripts.State_Machine_Trys.FSM_Enes
{
    public class WalkingState : MonoBehaviour , StateManager.IState
    {
        public void OnEnter()
        {
            print("Walking Entered");
        }

        public void OnUpdate()
        {
            print("Walking Updating");
        }

        public void OnExit()
        {
            print("Walking Exit");
        }
    }
}

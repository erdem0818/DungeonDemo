using System;
using System.Threading.Tasks;

namespace GameFolders.Scripts.State_Machine_Trys.FSM_Erdem
{
    public class StateMachine
    {
        private BaseState CurrentState { get; set; }

        public StateMachine(BaseState firstState)
        {
            CurrentState = firstState;
        }

        public void Init()
        {
            CurrentState.OnEnter();
        }

        public void ChangeState(BaseState newState)
        {
            if (CurrentState == newState) return;
            
            //CurrentState.OnExit();

            CurrentState = newState;
            newState.OnEnter();
        }
    }
}

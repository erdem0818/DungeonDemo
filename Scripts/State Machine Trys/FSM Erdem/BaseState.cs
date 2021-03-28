using UnityEngine;

namespace GameFolders.Scripts.State_Machine_Trys.FSM_Erdem
{
    public abstract class BaseState
    {
        private Animator _animator;

        protected BaseState(Animator animator)
        {
            _animator = animator;
        }
        public virtual void OnEnter()
        {
            
        }

        public virtual void OnUpdate()
        {
            
        }

        public virtual void OnExit()
        {
            
        }
    }
}

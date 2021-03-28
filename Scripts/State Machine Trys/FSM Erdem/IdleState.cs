using UnityEngine;

namespace GameFolders.Scripts.State_Machine_Trys.FSM_Erdem
{
    public class IdleState : BaseState
    {
        private Animator _animator;
        public const string IDLE_ANIM = "IDLE";
        public IdleState(Animator animator) : base(animator)
        {
            _animator = animator;
        }

        public override void OnEnter()
        {
            _animator.CrossFade(IDLE_ANIM,0.1f);
        }
    }
}

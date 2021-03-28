using UnityEngine;

namespace GameFolders.Scripts.State_Machine_Trys.FSM_Erdem
{
    public class WalkingState : BaseState
    {
        private Animator _animator;
        public const string WALK_ANIM = "WALK";
        public WalkingState(Animator animator) : base(animator)
        {
            _animator = animator;
        }

        public override void OnEnter()
        {
            _animator.CrossFade(WALK_ANIM, 0.1f);
        }
    }
}

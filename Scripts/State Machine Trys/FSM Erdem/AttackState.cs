using UnityEngine;

namespace GameFolders.Scripts.State_Machine_Trys.FSM_Erdem
{
    public class AttackState : BaseState
    {
        private Animator _animator;
        public const string ATTACK_ANIM = "ATTACK";

        public AttackState(Animator animator) : base(animator)
        {
            _animator = animator;
        }

        public override void OnEnter()
        {
            _animator.CrossFade(ATTACK_ANIM,0f);
        }
    }
}

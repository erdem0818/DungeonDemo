using UnityEngine;

namespace GameFolders.Scripts.State_Machine_Trys.FSM_Erdem
{
    public class ComboState : BaseState
    {
        private Animator _animator;
        public const string COMBO_ATTACK = "ATTACKCOMBO";
        
        public ComboState(Animator animator) : base(animator)
        {
            _animator = animator;
        }

        public override void OnEnter()
        {
            _animator.CrossFade(COMBO_ATTACK,0f);
        }
    }
}

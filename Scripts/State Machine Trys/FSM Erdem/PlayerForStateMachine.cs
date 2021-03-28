using System.Collections;
using UnityEngine;

namespace GameFolders.Scripts.State_Machine_Trys.FSM_Erdem
{
    public class PlayerForStateMachine : MonoBehaviour
    {
        private StateMachine _stateMachine;
        
        //---------- STATES --------------
        private IdleState _idleState;
        private WalkingState _walkingState;
        private AttackState _attackState;
        private ComboState _comboState;
        //--------------------------------
        
        //---------- COMPONENTS -----------
        private Animator _animator;
        //--------------------------------

        private bool _isWalking = false;
        private bool _isAttacking = false;
        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void Start()
        {
            _idleState = new IdleState(_animator);
            _walkingState = new WalkingState(_animator);
            _attackState = new AttackState(_animator);
            _comboState = new ComboState(_animator);
            
            _stateMachine = new StateMachine(_idleState);
            _stateMachine.Init();
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.K) && !_isWalking && !_isAttacking)
            {
                _stateMachine.ChangeState(_walkingState);
                _isWalking = true;
            }
            else if(Input.GetKeyDown(KeyCode.K) && _isWalking && !_isAttacking)
            {
                _stateMachine.ChangeState(_idleState);
                _isWalking = false;
            }

            if(Input.GetMouseButtonDown(0) && !_isAttacking)
            {
                _isAttacking = true;
                StartCoroutine(PlayOneTimeAnimation(_attackState, _idleState));
            }

            if(Input.GetKeyDown(KeyCode.Alpha3) && !_isAttacking)
            {
                _isAttacking = true;
                StartCoroutine(PlayOneTimeAnimation(_comboState, _idleState));
            }
        }

        private IEnumerator PlayOneTimeAnimation(BaseState playState, BaseState endState)
        {
            _stateMachine.ChangeState(playState);
            yield return new WaitForEndOfFrame();
            var time = _animator.GetCurrentAnimatorStateInfo(0).length;
            yield return new WaitForSeconds(time);
            _stateMachine.ChangeState(endState);
            _isAttacking = false;
            
            if (endState == _idleState)
                _isWalking = false;
        }
        
    }
}
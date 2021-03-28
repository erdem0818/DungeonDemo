using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameFolders.Scripts.State_Machine_Trys.FSM_Enes
{
    public class StateManager : MonoBehaviour
    {
        public interface IState
        {
            void OnEnter();
            void OnUpdate();
            void OnExit();
        }
        public enum PlayerStates
        {
            Idle,
            Walking,
            Finish
        }
    
        [SerializeField] private List<StateData> _gameStateList=new List<StateData>();
        //public PlayerStates playerStates;
        private static IState _currentState;
        private bool _isOnce = true;
    
        private void Awake()
        {
            Application.targetFrameRate = 60;
            ChangeState(PlayerStates.Idle);
        
        }

        private void Update()
        {
            _currentState?.OnUpdate();

            if (Input.GetKeyDown(KeyCode.K) && _isOnce)
            {
                ChangeState(PlayerStates.Walking);
                _isOnce = false;
            }
            else if (Input.GetKeyDown(KeyCode.K) && !_isOnce)
            {
                ChangeState(PlayerStates.Idle);
                _isOnce = true;
            }

        }

        #region StateMachine

        public void ChangeState(PlayerStates nextState)
        {

            IState _nextState = _gameStateList.LastOrDefault(x=> x._statesEnum==nextState)?._stateScript as IState;
            //PlayerStates nexteEnum = _gameStateList.LastOrDefault(x => x._statesEnum == nextState)._statesEnum;
            if (_currentState==_nextState)
            {
                return;
            }
            _currentState?.OnExit();
            _currentState = _nextState;
            _currentState?.OnEnter();
        
        }
        public IState GETCurrentState()
        {
            return _currentState;
        } 
        [System.Serializable]
        public class StateData
        {
            public PlayerStates _statesEnum;
            public MonoBehaviour _stateScript;
        }
        #endregion
    
    
    
    }
}

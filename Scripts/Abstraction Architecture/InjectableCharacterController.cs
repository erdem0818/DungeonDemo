using System;
using System.Collections.Generic;
using Abstraction_Architecture;
using UnityEngine;


namespace GameFolders.Scripts.Abstraction_Architecture
{
    [RequireComponent(typeof(Rigidbody))]
    public class InjectableCharacterController : MonoBehaviour
    {
        #region Components
        private Rigidbody _rigidbody;
        #endregion

        private Dictionary<Type, IStateProvider> _states;

        private List<IActionProvider> _actions;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            _states = new Dictionary<Type, IStateProvider>
            {
                {typeof(MovementInputStateProvider), new MovementInputStateProvider()},
                {typeof(PlayerPositionStateProvider), new PlayerPositionStateProvider(transform,_rigidbody)},
                {typeof(FireInputStateProvider), new FireInputStateProvider()} //Skill System, Skill Input Provider 
            };
            //*****************
            _actions = new List<IActionProvider>
            {
                new MovementAction(_states, 50f),
                new FireAction(_states)
            };
        }

        private void Update()
        {
            foreach (var action in _actions)
            {
                action.Act();
            }
        }
    }
}

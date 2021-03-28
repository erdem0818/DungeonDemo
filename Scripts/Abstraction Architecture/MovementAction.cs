using System;
using System.Collections.Generic;
using Abstraction_Architecture;
using GameFolders.Scripts.State_Machine_Trys.FSM_Enes;
using UnityEngine;

namespace GameFolders.Scripts.Abstraction_Architecture
{
    public class MovementAction : IActionProvider
    {
        //diger behaviour sisteminden farkı IMove, IFire gibi interfaceleri örneklemiyoruz. onun yerini stateProvider'lar alıyor.??
        private MovementInputStateProvider _movement;
        private PlayerPositionStateProvider _playerPosition;
        private float _speed;
        public MovementAction(IReadOnlyDictionary<Type, IStateProvider> stateProviders, float speed)
        {
            _movement = (MovementInputStateProvider)stateProviders[typeof(MovementInputStateProvider)];
            _playerPosition =
                (PlayerPositionStateProvider) stateProviders[typeof(PlayerPositionStateProvider)];
            _speed = speed;
        }
       // Act() fonksiyonu içinde örneklediğimiz stateProvider sınıflarını parametre olarak verdiğimiz dictionary içinde buluyor key'ine göre 
       public void Act() // List linq  // artık bu parametreyi almasına gerek yok. -->> Dictionary<Type, IStateProvider> stateProviders
       {
            var z = (_movement.Vertical * Time.deltaTime * _speed);
            var x = (_movement.Horizontal * Time.deltaTime * _speed);

            _playerPosition.EulerAngles += new Vector3(_playerPosition.EulerAngles.x, x, _playerPosition.EulerAngles.z);
            //_playerPosition.Velocity = new Vector3(0f,0f,z); // forward olmalı.
            _playerPosition.TransformComp.position += _playerPosition.TransformComp.forward * (z * Time.deltaTime);
       }
    }
}
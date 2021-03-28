using System;
using System.Collections.Generic;
using Abstraction_Architecture;
using UnityEngine;

namespace GameFolders.Scripts.Abstraction_Architecture
{
    public class FireAction : IActionProvider
    {
        private FireInputStateProvider _fireState;

        //Dictionary<Type, IStateProvider> stateProviders
        public FireAction(IReadOnlyDictionary<Type, IStateProvider> stateProviders)
        {
            _fireState = (FireInputStateProvider)stateProviders[typeof(FireInputStateProvider)];
        }
        
        public void Act() // artık bu parametreyi almasına gerek yok. -->> Dictionary<Type, IStateProvider> stateProviders
        {
            //FireInputStateProvider fireState = (FireInputStateProvider)stateProviders[typeof(FireInputStateProvider)]; // new FireInputStateProveder();
        
            //if(fireState.IsFıre)
            //    Debug.Log("Fired");
            
            //if(_fireState.IsFıre)
                //Debug.Log("Fired");
        }
    }
}

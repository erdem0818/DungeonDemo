using Abstraction_Architecture;
using UnityEngine;

namespace GameFolders.Scripts.Abstraction_Architecture
{
    public class PlayerPositionStateProvider : IStateProvider
    {
        private Transform _transform;
        private Rigidbody _rigidbody;
        public PlayerPositionStateProvider(Transform transform, Rigidbody rigidbody) //constructor'lar ayırılabilir
        {
            _transform = transform;
            _rigidbody = rigidbody;
        }
        public virtual Transform TransformComp
        {
            get => _transform;
            set => _transform = value;
        }

        public virtual Vector3 Velocity
        {
            get => _rigidbody.velocity;
            set => _rigidbody.velocity = value;
        }

        public virtual Vector3 EulerAngles
        {
            get => _transform.eulerAngles;
            set => _transform.eulerAngles = value;
        }
    }
}
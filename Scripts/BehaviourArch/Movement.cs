using UnityEngine;

namespace GameFolders.Scripts.BehaviourArch
{
    public class Movement : IExecute
    {
        private IMove _move;
        public Movement(IMove move)
        {
            _move = move;
        }
        public void Execute()
        {
            var x = Input.GetAxis("Horizontal") * _move.GetSpeed() * Time.deltaTime;
            var y = Input.GetAxis("Vertical") * _move.GetSpeed() * Time.deltaTime;
            _move.GetRigidbody().velocity = new Vector3(x,y);
        }
    }
}
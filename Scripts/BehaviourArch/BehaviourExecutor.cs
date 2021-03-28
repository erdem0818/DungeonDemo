using UnityEngine;

namespace GameFolders.Scripts.BehaviourArch
{
    public class BehaviourExecutor : MonoBehaviour ,IMove
    {
        #region Components
        private Rigidbody _rigidbody;
        private float _speed = 138f;
        #endregion
        
        #region Getters
        public Rigidbody GetRigidbody() => _rigidbody;
        public float GetSpeed() => _speed;
        #endregion
        
        //private IList<IExecute> _executeList;
        private IExecute[] _executeArray; //initialize in start?

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            _executeArray = new IExecute[] {new Movement(this)};
        }

        private void Update()
        {
            foreach (var behavioour in _executeArray)
            {
                behavioour.Execute();
            }
        }
    }
}

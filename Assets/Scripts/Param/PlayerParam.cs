using UnityEngine;

namespace AAAR
{
    public class PlayerParam : MonoBehaviour
    {
        protected NewControls _controls;
        protected Rigidbody _rbPlayer;

        [SerializeField]
        protected GameObject _bulletPrefab;

        [SerializeField]
        protected Transform[] _fireTarget;

        [Space, SerializeField, Range(0f, 100f)]
        private float _speedMovePlayer;
        public float GetMovement() => _speedMovePlayer;

        [SerializeField, Range(0f, 90f)]
        private float _speedRotationPlayer;
        public float GetRotation() => _speedRotationPlayer;

        [SerializeField, Range(1f, 10f)]
        protected float _timeBetweenShoot;

        protected bool _canShoot = true;
    }
}

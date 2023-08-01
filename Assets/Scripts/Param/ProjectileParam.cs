using UnityEngine;


namespace AAAR
{
    class ProjectileParam : MonoBehaviour
    {
        protected Transform _player;
        protected Vector3 _target;

        [Space, SerializeField, Range(0f, 100f)]
        private float _speedMoveProjectile;
        protected float SpeedMoveProjectile => _speedMoveProjectile;
    }
}

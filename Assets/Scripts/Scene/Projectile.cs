using UnityEngine;

namespace AAAR
{
    class Projectile: ProjectileParam
    {
        private void Start()
        {
             _player = GameObject.FindGameObjectWithTag("Player").transform;
             _target = new Vector3(_player.position.x, _player.position.y, _player.position.z);
        }

        private void Update()
        {
            MovementBullet();
        }

        void MovementBullet()
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, SpeedMoveProjectile * Time.deltaTime);
        }
    }
}

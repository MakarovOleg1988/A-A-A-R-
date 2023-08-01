using System;
using System.Collections;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace AAAR
{
    public class PlayerMovementandAttack : PlayerParam
    {
        private void Awake()
        {
            _controls = new NewControls();
        }

        private void Start()
        {
            _rbPlayer = GetComponent<Rigidbody>();
        }

        private void OnEnable()
        {
            _controls.NewActionMap.Enable();
            _controls.NewActionMap.Movement.Enable();
            _controls.NewActionMap.Rotation.Enable();
            _controls.NewActionMap.Shoot.performed += Shoot;
        }

        private void Update()
        {
            Movement();
            Rotation();
        }

        private void Movement()
        {
            var valueUp = _controls.NewActionMap.Movement.ReadValue<float>();
            transform.Translate(Vector3.forward * valueUp * GetMovement() * Time.deltaTime);
        }

        private void Rotation()
        {
            var valueRotateRight = _controls.NewActionMap.Rotation.ReadValue<float>();
            transform.Rotate(Vector3.up, valueRotateRight * GetRotation() * Time.deltaTime);
        }

        private void Shoot(CallbackContext context)
        {
            if (_canShoot == true)
            {
                for (int i = _fireTarget.Length - 1; i > 0; i--)
                {
                    var bullet = Instantiate(_bulletPrefab, _fireTarget[i].transform.position, transform.rotation);
                }
                
                _canShoot = false;
            }
            
            StartCoroutine(TimerBetweenShoot());
        }

        private IEnumerator TimerBetweenShoot()
        {
            yield return new WaitForSeconds(_timeBetweenShoot);
            _canShoot = true;
        }
    }
}
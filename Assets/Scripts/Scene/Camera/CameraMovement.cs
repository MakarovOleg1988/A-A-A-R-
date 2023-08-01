using UnityEngine;

namespace AAAR
{
    public class CameraMovement : CameraParam
    {
        private void Awake()
        {
            _Controller = new NewControls();
        }

        private void Start()
        {
            _target = transform.parent.GetComponent<PlayerMovementandAttack>();
            _transformCameraPivot = transform.GetChild(0);
            _pivotEulers = _transformCameraPivot.eulerAngles;
        }

        private void OnEnable()
        {
            _Controller.DeltaCamera.Enable();
        }

        private void LateUpdate()
        {
            transform.position = Vector3.Lerp(transform.position, _target.transform.position, Time.deltaTime * _speedMovementCamera);
            FreeCamera();
        }

        private void FreeCamera()
        {
            Vector2 delta = _Controller.DeltaCamera.CameraMovement.ReadValue<Vector2>();


            _angleX += delta.x * _speedRotationCamera;
            _angleY -= delta.y * _speedRotationCamera;


            _angleY = Mathf.Clamp(_angleY, _minY, _maxY);

            _pivotTargetRotation = Quaternion.Euler(_angleY, _pivotEulers.y, _pivotEulers.z);
            _transformTargetRotation = Quaternion.Euler(0f, _angleX, 0f);

            _transformCameraPivot.localRotation = Quaternion.Slerp(_transformCameraPivot.localRotation, _pivotTargetRotation, _smoothing * Time.deltaTime);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, _transformTargetRotation, _smoothing * Time.deltaTime);
        }


        private void OnDisable()
        {
            _Controller.DeltaCamera.Disable();
        }

        private void OnDestroy()
        {
            _Controller.Dispose();
        }
    }
}

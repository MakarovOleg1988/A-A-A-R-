using UnityEngine;

namespace AAAR
{
    public class CameraParam : MonoBehaviour
    {
        protected NewControls _Controller;
        protected PlayerMovementandAttack _target;
        protected Transform _transformCameraPivot;

        //������� ������ �� ���������
        protected Quaternion _pivotTargetRotation;
        //������� ����� ������ �� �����������
        protected Quaternion _transformTargetRotation;

        protected Vector3 _pivotEulers;
        protected Camera _camera;
        public Transform CameraTransform => _camera.transform;
        protected Transform _nextPoint;


        //������� ��������� �������� ��� ��
        protected float _angleX;
        //������� ��������� �������� ��� �Y
        protected float _angleY;

        [SerializeField, Range(0f, 90f), Tooltip("������������ ������ ������ �� ���������")]
        protected float _maxY = 45f;

        [SerializeField, Range(-90f, 0f), Tooltip("����������� ������ ������ �� ���������")]
        protected float _minY = -45f;

        [SerializeField, Range(10f, 0f), Tooltip("����������� �������� ������")]
        protected float _smoothing = 5f;

        [Space, SerializeField, Range(0f, 10f)]
        protected float _speedMovementCamera = 4f;

        [SerializeField, Range(0f, 2f)]
        protected float _speedRotationCamera = 0.2f;

        [SerializeField, Range(0f, 2f)]
        protected float _speedRotationCameraMobile = 2f;

        [SerializeField, Range(0f, 10f)]
        protected float _timeToMove;

    }
}

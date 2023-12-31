//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Player/New Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace AAAR
{
    public partial class @NewControls : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @NewControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""New Action Map"",
            ""id"": ""d8a5fbfa-b87a-4488-a42b-68e082514a88"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""3ba3d894-e2c8-43d1-b540-3a17c6d2400f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""a678c5fc-58ab-4995-9ad8-420572b956c4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""1f559d95-602e-48c7-9d17-937731866ba7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""75804588-fbe5-48bc-a8ae-236f11092cea"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0022361c-a3bd-4925-8339-a16768ed46bc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d70e3eba-d6de-4315-a521-d69d6745aa3e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""eb5f23cc-5a4b-49b5-bfb3-e057ca03d5a2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""067379c1-6ff4-4d26-9ca3-977df402779a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""23b9e6dc-b991-4ba8-aabc-7a8a11309713"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a5708d95-4190-4fed-9e96-47229d3b1295"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DeltaCamera"",
            ""id"": ""c5c4c1c1-ef5c-48c7-80c0-53064c836b3f"",
            ""actions"": [
                {
                    ""name"": ""CameraMovement"",
                    ""type"": ""Value"",
                    ""id"": ""41cee808-f4d2-40fc-b52d-7283775ebd65"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bfc17e4a-f34b-4ed4-b4e2-abe695cb4583"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // New Action Map
            m_NewActionMap = asset.FindActionMap("New Action Map", throwIfNotFound: true);
            m_NewActionMap_Movement = m_NewActionMap.FindAction("Movement", throwIfNotFound: true);
            m_NewActionMap_Rotation = m_NewActionMap.FindAction("Rotation", throwIfNotFound: true);
            m_NewActionMap_Shoot = m_NewActionMap.FindAction("Shoot", throwIfNotFound: true);
            // DeltaCamera
            m_DeltaCamera = asset.FindActionMap("DeltaCamera", throwIfNotFound: true);
            m_DeltaCamera_CameraMovement = m_DeltaCamera.FindAction("CameraMovement", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // New Action Map
        private readonly InputActionMap m_NewActionMap;
        private INewActionMapActions m_NewActionMapActionsCallbackInterface;
        private readonly InputAction m_NewActionMap_Movement;
        private readonly InputAction m_NewActionMap_Rotation;
        private readonly InputAction m_NewActionMap_Shoot;
        public struct NewActionMapActions
        {
            private @NewControls m_Wrapper;
            public NewActionMapActions(@NewControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_NewActionMap_Movement;
            public InputAction @Rotation => m_Wrapper.m_NewActionMap_Rotation;
            public InputAction @Shoot => m_Wrapper.m_NewActionMap_Shoot;
            public InputActionMap Get() { return m_Wrapper.m_NewActionMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(NewActionMapActions set) { return set.Get(); }
            public void SetCallbacks(INewActionMapActions instance)
            {
                if (m_Wrapper.m_NewActionMapActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_NewActionMapActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_NewActionMapActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_NewActionMapActionsCallbackInterface.OnMovement;
                    @Rotation.started -= m_Wrapper.m_NewActionMapActionsCallbackInterface.OnRotation;
                    @Rotation.performed -= m_Wrapper.m_NewActionMapActionsCallbackInterface.OnRotation;
                    @Rotation.canceled -= m_Wrapper.m_NewActionMapActionsCallbackInterface.OnRotation;
                    @Shoot.started -= m_Wrapper.m_NewActionMapActionsCallbackInterface.OnShoot;
                    @Shoot.performed -= m_Wrapper.m_NewActionMapActionsCallbackInterface.OnShoot;
                    @Shoot.canceled -= m_Wrapper.m_NewActionMapActionsCallbackInterface.OnShoot;
                }
                m_Wrapper.m_NewActionMapActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Rotation.started += instance.OnRotation;
                    @Rotation.performed += instance.OnRotation;
                    @Rotation.canceled += instance.OnRotation;
                    @Shoot.started += instance.OnShoot;
                    @Shoot.performed += instance.OnShoot;
                    @Shoot.canceled += instance.OnShoot;
                }
            }
        }
        public NewActionMapActions @NewActionMap => new NewActionMapActions(this);

        // DeltaCamera
        private readonly InputActionMap m_DeltaCamera;
        private IDeltaCameraActions m_DeltaCameraActionsCallbackInterface;
        private readonly InputAction m_DeltaCamera_CameraMovement;
        public struct DeltaCameraActions
        {
            private @NewControls m_Wrapper;
            public DeltaCameraActions(@NewControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @CameraMovement => m_Wrapper.m_DeltaCamera_CameraMovement;
            public InputActionMap Get() { return m_Wrapper.m_DeltaCamera; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DeltaCameraActions set) { return set.Get(); }
            public void SetCallbacks(IDeltaCameraActions instance)
            {
                if (m_Wrapper.m_DeltaCameraActionsCallbackInterface != null)
                {
                    @CameraMovement.started -= m_Wrapper.m_DeltaCameraActionsCallbackInterface.OnCameraMovement;
                    @CameraMovement.performed -= m_Wrapper.m_DeltaCameraActionsCallbackInterface.OnCameraMovement;
                    @CameraMovement.canceled -= m_Wrapper.m_DeltaCameraActionsCallbackInterface.OnCameraMovement;
                }
                m_Wrapper.m_DeltaCameraActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @CameraMovement.started += instance.OnCameraMovement;
                    @CameraMovement.performed += instance.OnCameraMovement;
                    @CameraMovement.canceled += instance.OnCameraMovement;
                }
            }
        }
        public DeltaCameraActions @DeltaCamera => new DeltaCameraActions(this);
        public interface INewActionMapActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnRotation(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
        }
        public interface IDeltaCameraActions
        {
            void OnCameraMovement(InputAction.CallbackContext context);
        }
    }
}

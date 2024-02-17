//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/NinjaInputActions.inputactions
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

public partial class @NinjaInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NinjaInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""NinjaInputActions"",
    ""maps"": [
        {
            ""name"": ""Ninja"",
            ""id"": ""783cefc1-caa3-4d72-81aa-438fd8321438"",
            ""actions"": [
                {
                    ""name"": ""Rasengan"",
                    ""type"": ""Button"",
                    ""id"": ""a1d2e8a0-e05b-49d7-9aa3-7a4bd3303a3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""b93e48bf-ca42-4afa-9227-c06cfc87164b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""96ae2bc2-33f4-43ec-ace6-4f3bcf86c382"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Die"",
                    ""type"": ""Button"",
                    ""id"": ""fe9adaaa-c5ab-4098-9871-f523ea3029c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""57c9679a-19cb-49d0-8a9c-318e563dbd70"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rasengan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27ce2f8f-554d-49c2-9c84-e184bc3299dd"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""e9afea72-1670-4394-84df-ea78916fdc49"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""e081ed1e-5193-4d93-b1ea-9a265205b12a"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""b264d431-f88f-44ff-bd18-5d658cc43ae8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""86381dac-25bf-4d2c-bed6-7dc4ce0dc24d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8eaf1448-181e-4fef-b92a-0a1b0e72a799"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d719ae60-e705-424c-987c-21c83a358eb2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""556ccca5-1524-4c8f-86e9-77449a9227a1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""274f6502-2a33-47ac-aa8c-17d39070cdfb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Flying"",
            ""id"": ""f0ac2b58-0592-4253-b4f6-9809e0fb93df"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""59bc5aa1-f181-41a7-9c9f-57e91a3d8832"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7b0a3733-7748-4702-ab44-835bd3d11168"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ninja
        m_Ninja = asset.FindActionMap("Ninja", throwIfNotFound: true);
        m_Ninja_Rasengan = m_Ninja.FindAction("Rasengan", throwIfNotFound: true);
        m_Ninja_Walk = m_Ninja.FindAction("Walk", throwIfNotFound: true);
        m_Ninja_Run = m_Ninja.FindAction("Run", throwIfNotFound: true);
        m_Ninja_Die = m_Ninja.FindAction("Die", throwIfNotFound: true);
        // Flying
        m_Flying = asset.FindActionMap("Flying", throwIfNotFound: true);
        m_Flying_Newaction = m_Flying.FindAction("New action", throwIfNotFound: true);
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

    // Ninja
    private readonly InputActionMap m_Ninja;
    private List<INinjaActions> m_NinjaActionsCallbackInterfaces = new List<INinjaActions>();
    private readonly InputAction m_Ninja_Rasengan;
    private readonly InputAction m_Ninja_Walk;
    private readonly InputAction m_Ninja_Run;
    private readonly InputAction m_Ninja_Die;
    public struct NinjaActions
    {
        private @NinjaInputActions m_Wrapper;
        public NinjaActions(@NinjaInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rasengan => m_Wrapper.m_Ninja_Rasengan;
        public InputAction @Walk => m_Wrapper.m_Ninja_Walk;
        public InputAction @Run => m_Wrapper.m_Ninja_Run;
        public InputAction @Die => m_Wrapper.m_Ninja_Die;
        public InputActionMap Get() { return m_Wrapper.m_Ninja; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NinjaActions set) { return set.Get(); }
        public void AddCallbacks(INinjaActions instance)
        {
            if (instance == null || m_Wrapper.m_NinjaActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_NinjaActionsCallbackInterfaces.Add(instance);
            @Rasengan.started += instance.OnRasengan;
            @Rasengan.performed += instance.OnRasengan;
            @Rasengan.canceled += instance.OnRasengan;
            @Walk.started += instance.OnWalk;
            @Walk.performed += instance.OnWalk;
            @Walk.canceled += instance.OnWalk;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @Die.started += instance.OnDie;
            @Die.performed += instance.OnDie;
            @Die.canceled += instance.OnDie;
        }

        private void UnregisterCallbacks(INinjaActions instance)
        {
            @Rasengan.started -= instance.OnRasengan;
            @Rasengan.performed -= instance.OnRasengan;
            @Rasengan.canceled -= instance.OnRasengan;
            @Walk.started -= instance.OnWalk;
            @Walk.performed -= instance.OnWalk;
            @Walk.canceled -= instance.OnWalk;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @Die.started -= instance.OnDie;
            @Die.performed -= instance.OnDie;
            @Die.canceled -= instance.OnDie;
        }

        public void RemoveCallbacks(INinjaActions instance)
        {
            if (m_Wrapper.m_NinjaActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(INinjaActions instance)
        {
            foreach (var item in m_Wrapper.m_NinjaActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_NinjaActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public NinjaActions @Ninja => new NinjaActions(this);

    // Flying
    private readonly InputActionMap m_Flying;
    private List<IFlyingActions> m_FlyingActionsCallbackInterfaces = new List<IFlyingActions>();
    private readonly InputAction m_Flying_Newaction;
    public struct FlyingActions
    {
        private @NinjaInputActions m_Wrapper;
        public FlyingActions(@NinjaInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Flying_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Flying; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlyingActions set) { return set.Get(); }
        public void AddCallbacks(IFlyingActions instance)
        {
            if (instance == null || m_Wrapper.m_FlyingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_FlyingActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IFlyingActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IFlyingActions instance)
        {
            if (m_Wrapper.m_FlyingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IFlyingActions instance)
        {
            foreach (var item in m_Wrapper.m_FlyingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_FlyingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public FlyingActions @Flying => new FlyingActions(this);
    public interface INinjaActions
    {
        void OnRasengan(InputAction.CallbackContext context);
        void OnWalk(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnDie(InputAction.CallbackContext context);
    }
    public interface IFlyingActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
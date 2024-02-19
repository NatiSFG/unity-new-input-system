//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/ColorInputAsset.inputactions
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

public partial class @ColorInputAsset: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ColorInputAsset()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ColorInputAsset"",
    ""maps"": [
        {
            ""name"": ""Color"",
            ""id"": ""8e0cdfbc-7633-4589-85c7-9b3a6f30dd5c"",
            ""actions"": [
                {
                    ""name"": ""Random Color"",
                    ""type"": ""Button"",
                    ""id"": ""4b3d34c3-0ffb-4cad-b4c5-8666540cc64a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b1696a3e-69b3-4144-8255-8c62240f5f09"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Random Color"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Color
        m_Color = asset.FindActionMap("Color", throwIfNotFound: true);
        m_Color_RandomColor = m_Color.FindAction("Random Color", throwIfNotFound: true);
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

    // Color
    private readonly InputActionMap m_Color;
    private List<IColorActions> m_ColorActionsCallbackInterfaces = new List<IColorActions>();
    private readonly InputAction m_Color_RandomColor;
    public struct ColorActions
    {
        private @ColorInputAsset m_Wrapper;
        public ColorActions(@ColorInputAsset wrapper) { m_Wrapper = wrapper; }
        public InputAction @RandomColor => m_Wrapper.m_Color_RandomColor;
        public InputActionMap Get() { return m_Wrapper.m_Color; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ColorActions set) { return set.Get(); }
        public void AddCallbacks(IColorActions instance)
        {
            if (instance == null || m_Wrapper.m_ColorActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ColorActionsCallbackInterfaces.Add(instance);
            @RandomColor.started += instance.OnRandomColor;
            @RandomColor.performed += instance.OnRandomColor;
            @RandomColor.canceled += instance.OnRandomColor;
        }

        private void UnregisterCallbacks(IColorActions instance)
        {
            @RandomColor.started -= instance.OnRandomColor;
            @RandomColor.performed -= instance.OnRandomColor;
            @RandomColor.canceled -= instance.OnRandomColor;
        }

        public void RemoveCallbacks(IColorActions instance)
        {
            if (m_Wrapper.m_ColorActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IColorActions instance)
        {
            foreach (var item in m_Wrapper.m_ColorActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ColorActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ColorActions @Color => new ColorActions(this);
    public interface IColorActions
    {
        void OnRandomColor(InputAction.CallbackContext context);
    }
}

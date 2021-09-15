// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/Scripts/InputSystem/BirdInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BirdInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BirdInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BirdInput"",
    ""maps"": [
        {
            ""name"": ""bird"",
            ""id"": ""82667600-b28a-4881-8bde-fc0c2a6fe8da"",
            ""actions"": [
                {
                    ""name"": ""fly"",
                    ""type"": ""Value"",
                    ""id"": ""5a1eaadc-e23c-405e-8171-b22f8c14e363"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8e79d1d2-0f34-4111-97f5-c470be7d2292"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""fly"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a7e16d41-6ef0-4bef-8b4c-aa577258887b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1d52734e-0457-4c49-afb3-7a44b282a903"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // bird
        m_bird = asset.FindActionMap("bird", throwIfNotFound: true);
        m_bird_fly = m_bird.FindAction("fly", throwIfNotFound: true);
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

    // bird
    private readonly InputActionMap m_bird;
    private IBirdActions m_BirdActionsCallbackInterface;
    private readonly InputAction m_bird_fly;
    public struct BirdActions
    {
        private @BirdInput m_Wrapper;
        public BirdActions(@BirdInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @fly => m_Wrapper.m_bird_fly;
        public InputActionMap Get() { return m_Wrapper.m_bird; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BirdActions set) { return set.Get(); }
        public void SetCallbacks(IBirdActions instance)
        {
            if (m_Wrapper.m_BirdActionsCallbackInterface != null)
            {
                @fly.started -= m_Wrapper.m_BirdActionsCallbackInterface.OnFly;
                @fly.performed -= m_Wrapper.m_BirdActionsCallbackInterface.OnFly;
                @fly.canceled -= m_Wrapper.m_BirdActionsCallbackInterface.OnFly;
            }
            m_Wrapper.m_BirdActionsCallbackInterface = instance;
            if (instance != null)
            {
                @fly.started += instance.OnFly;
                @fly.performed += instance.OnFly;
                @fly.canceled += instance.OnFly;
            }
        }
    }
    public BirdActions @bird => new BirdActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IBirdActions
    {
        void OnFly(InputAction.CallbackContext context);
    }
}

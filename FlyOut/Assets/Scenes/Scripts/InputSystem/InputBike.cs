// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/Scripts/InputSystem/InputBike.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputBike : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputBike()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputBike"",
    ""maps"": [
        {
            ""name"": ""bike"",
            ""id"": ""b3533ecd-b8c7-4a0c-b37a-e2ee6a49503f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""f0878fe9-8098-4f15-af87-0e1cf353d51e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""push"",
                    ""type"": ""Button"",
                    ""id"": ""9acb6bf6-918b-40a4-b7a9-fdf0ed79a196"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""115a668c-da2e-46e4-9412-2116ab4c6a16"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""push"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e73a2114-87ed-43ef-b683-a6e3cd29818b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // bike
        m_bike = asset.FindActionMap("bike", throwIfNotFound: true);
        m_bike_Move = m_bike.FindAction("Move", throwIfNotFound: true);
        m_bike_push = m_bike.FindAction("push", throwIfNotFound: true);
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

    // bike
    private readonly InputActionMap m_bike;
    private IBikeActions m_BikeActionsCallbackInterface;
    private readonly InputAction m_bike_Move;
    private readonly InputAction m_bike_push;
    public struct BikeActions
    {
        private @InputBike m_Wrapper;
        public BikeActions(@InputBike wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_bike_Move;
        public InputAction @push => m_Wrapper.m_bike_push;
        public InputActionMap Get() { return m_Wrapper.m_bike; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BikeActions set) { return set.Get(); }
        public void SetCallbacks(IBikeActions instance)
        {
            if (m_Wrapper.m_BikeActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BikeActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BikeActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BikeActionsCallbackInterface.OnMove;
                @push.started -= m_Wrapper.m_BikeActionsCallbackInterface.OnPush;
                @push.performed -= m_Wrapper.m_BikeActionsCallbackInterface.OnPush;
                @push.canceled -= m_Wrapper.m_BikeActionsCallbackInterface.OnPush;
            }
            m_Wrapper.m_BikeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @push.started += instance.OnPush;
                @push.performed += instance.OnPush;
                @push.canceled += instance.OnPush;
            }
        }
    }
    public BikeActions @bike => new BikeActions(this);
    public interface IBikeActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPush(InputAction.CallbackContext context);
    }
}

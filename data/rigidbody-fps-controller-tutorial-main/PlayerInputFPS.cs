//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/data/rigidbody-fps-controller-tutorial-main/PlayerInputFPS.inputactions
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

public partial class @PlayerInputFPS : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputFPS()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputFPS"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""2df049c0-2954-4a3b-871e-e5f3b87fb656"",
            ""actions"": [
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""4a60cf87-2049-422f-8417-926274114d8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""sprint"",
                    ""type"": ""Button"",
                    ""id"": ""45f963fe-00ee-456e-aff1-079d2ac14202"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""dash"",
                    ""type"": ""Button"",
                    ""id"": ""c351853c-393d-47da-a5e9-c8e0e28a0dbd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""attack"",
                    ""type"": ""Button"",
                    ""id"": ""50dbd968-1f62-44a9-8863-136d44f3a579"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseLook"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c04a6559-3c3a-4b75-8434-e62957220e96"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c4db3bc1-1497-40d2-9e75-38078b2f4459"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c131486e-e044-406b-8409-7a9b12c317d4"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c870fcf-cffd-4310-8e12-5209721ed8a3"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b4a604a-a5dd-4d0d-9634-d75c356a9119"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c33c56c7-2623-4787-9501-f0b07f11b247"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""MouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""keyboard"",
            ""bindingGroup"": ""keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_jump = m_player.FindAction("jump", throwIfNotFound: true);
        m_player_sprint = m_player.FindAction("sprint", throwIfNotFound: true);
        m_player_dash = m_player.FindAction("dash", throwIfNotFound: true);
        m_player_attack = m_player.FindAction("attack", throwIfNotFound: true);
        m_player_MouseLook = m_player.FindAction("MouseLook", throwIfNotFound: true);
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

    // player
    private readonly InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_player_jump;
    private readonly InputAction m_player_sprint;
    private readonly InputAction m_player_dash;
    private readonly InputAction m_player_attack;
    private readonly InputAction m_player_MouseLook;
    public struct PlayerActions
    {
        private @PlayerInputFPS m_Wrapper;
        public PlayerActions(@PlayerInputFPS wrapper) { m_Wrapper = wrapper; }
        public InputAction @jump => m_Wrapper.m_player_jump;
        public InputAction @sprint => m_Wrapper.m_player_sprint;
        public InputAction @dash => m_Wrapper.m_player_dash;
        public InputAction @attack => m_Wrapper.m_player_attack;
        public InputAction @MouseLook => m_Wrapper.m_player_MouseLook;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @dash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @dash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @dash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @MouseLook.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseLook;
                @MouseLook.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseLook;
                @MouseLook.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseLook;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @sprint.started += instance.OnSprint;
                @sprint.performed += instance.OnSprint;
                @sprint.canceled += instance.OnSprint;
                @dash.started += instance.OnDash;
                @dash.performed += instance.OnDash;
                @dash.canceled += instance.OnDash;
                @attack.started += instance.OnAttack;
                @attack.performed += instance.OnAttack;
                @attack.canceled += instance.OnAttack;
                @MouseLook.started += instance.OnMouseLook;
                @MouseLook.performed += instance.OnMouseLook;
                @MouseLook.canceled += instance.OnMouseLook;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);
    private int m_keyboardSchemeIndex = -1;
    public InputControlScheme keyboardScheme
    {
        get
        {
            if (m_keyboardSchemeIndex == -1) m_keyboardSchemeIndex = asset.FindControlSchemeIndex("keyboard");
            return asset.controlSchemes[m_keyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnMouseLook(InputAction.CallbackContext context);
    }
}

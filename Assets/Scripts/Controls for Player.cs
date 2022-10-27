//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Controls for Player.inputactions
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

public partial class @ControlsforPlayer : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlsforPlayer()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls for Player"",
    ""maps"": [
        {
            ""name"": ""Inv"",
            ""id"": ""fd34008b-80e7-426d-97d4-7c82c44f2dfd"",
            ""actions"": [
                {
                    ""name"": ""Store"",
                    ""type"": ""Value"",
                    ""id"": ""fd1e9d33-dc43-4419-b81d-74f46283fac0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=1)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""5ed0ff00-4926-4efc-a969-e399a0c91f33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressPick"",
                    ""type"": ""Button"",
                    ""id"": ""137fa85d-f5ab-4b53-b7f3-1da9092e75c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HoldItem"",
                    ""type"": ""Button"",
                    ""id"": ""e3efaabd-f84c-4644-914b-028932e17948"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""249f10df-dcd2-4d2a-b7a2-a5310ed10354"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Store"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2d68109-9b48-4f39-8328-bd265a513646"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Store"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25af452b-f432-46da-8bd2-79f6244aeeed"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1442667d-a526-4eb4-9b71-7e1666b28729"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b4d538b-bf56-4a9f-a01a-eb3b48c54349"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad86e4db-23c8-4aac-9036-2eff151e3b10"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressPick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2643c2af-f640-46b5-b5a6-51cfe754008e"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressPick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6d45c2d-d454-4498-bf21-9142a5e2efa1"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoldItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Actions"",
            ""id"": ""e0f5a95b-511f-4b07-a28e-fa89eb759e3c"",
            ""actions"": [
                {
                    ""name"": ""Glide"",
                    ""type"": ""Button"",
                    ""id"": ""81c37c7b-46ca-44df-89ad-1757458b57c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dive"",
                    ""type"": ""Button"",
                    ""id"": ""63fb4c82-2fc1-4970-b6bb-fca2cb8c73b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GlideLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e8203e8b-3fc1-4b66-9508-615a9eb92162"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GlideRight"",
                    ""type"": ""Button"",
                    ""id"": ""2fca163b-c2dd-47df-ba3f-2bfd8aa1c8de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""76884bb7-09ba-4323-a932-4b7fb3bddc23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.1)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SwitchHat"",
                    ""type"": ""Button"",
                    ""id"": ""72f8dc6b-8a82-445e-92db-761c708e2da6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActivateHat"",
                    ""type"": ""Button"",
                    ""id"": ""740d3fcf-da47-42bd-a6e4-47e15688a7ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Snatch"",
                    ""type"": ""Button"",
                    ""id"": ""b40ae7e6-5c86-407a-b90e-eb9073176aa7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""33451d84-4d40-4673-9264-327a2b73831d"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Glide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3f384f7-5b85-414e-9d19-d2cbe32beefc"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Glide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c984d088-ea9b-4b9b-9b66-f62508c13fdd"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b58d955c-5a18-4026-a2c1-1c5a60bb0841"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90ac33f5-f896-4b4f-8a80-74b6d8058514"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GlideLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc2caacf-93cc-450a-824a-6ee2566ecbad"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GlideRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c464499-e9c0-47ea-8958-9a0e57b1061f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""751dfeb3-4ff1-4aa4-bb26-14ea9e2f36fe"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchHat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae0f4c6d-4ab1-4576-99c2-030cf45b3344"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateHat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e384cb0-76c0-4b1a-98a4-167984a63b59"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Snatch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Test"",
            ""id"": ""16c4472a-5611-435b-835b-4a121f3e8be4"",
            ""actions"": [
                {
                    ""name"": ""HealthTest"",
                    ""type"": ""Button"",
                    ""id"": ""1036cb9b-5a91-4891-9e58-cf4c70636b63"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1a7e2700-2a7e-4bc0-a937-dd0c5b317dec"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HealthTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuActions"",
            ""id"": ""a63f8fe0-889c-4137-8c17-e1bcc6f113c0"",
            ""actions"": [
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""f4f45f2f-7dc5-4d03-a2b2-2608f83357d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d5c1561a-0d3d-4241-8e65-4ed34889849d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Inv
        m_Inv = asset.FindActionMap("Inv", throwIfNotFound: true);
        m_Inv_Store = m_Inv.FindAction("Store", throwIfNotFound: true);
        m_Inv_Drop = m_Inv.FindAction("Drop", throwIfNotFound: true);
        m_Inv_PressPick = m_Inv.FindAction("PressPick", throwIfNotFound: true);
        m_Inv_HoldItem = m_Inv.FindAction("HoldItem", throwIfNotFound: true);
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_Glide = m_Actions.FindAction("Glide", throwIfNotFound: true);
        m_Actions_Dive = m_Actions.FindAction("Dive", throwIfNotFound: true);
        m_Actions_GlideLeft = m_Actions.FindAction("GlideLeft", throwIfNotFound: true);
        m_Actions_GlideRight = m_Actions.FindAction("GlideRight", throwIfNotFound: true);
        m_Actions_Jump = m_Actions.FindAction("Jump", throwIfNotFound: true);
        m_Actions_SwitchHat = m_Actions.FindAction("SwitchHat", throwIfNotFound: true);
        m_Actions_ActivateHat = m_Actions.FindAction("ActivateHat", throwIfNotFound: true);
        m_Actions_Snatch = m_Actions.FindAction("Snatch", throwIfNotFound: true);
        // Test
        m_Test = asset.FindActionMap("Test", throwIfNotFound: true);
        m_Test_HealthTest = m_Test.FindAction("HealthTest", throwIfNotFound: true);
        // MenuActions
        m_MenuActions = asset.FindActionMap("MenuActions", throwIfNotFound: true);
        m_MenuActions_Quit = m_MenuActions.FindAction("Quit", throwIfNotFound: true);
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

    // Inv
    private readonly InputActionMap m_Inv;
    private IInvActions m_InvActionsCallbackInterface;
    private readonly InputAction m_Inv_Store;
    private readonly InputAction m_Inv_Drop;
    private readonly InputAction m_Inv_PressPick;
    private readonly InputAction m_Inv_HoldItem;
    public struct InvActions
    {
        private @ControlsforPlayer m_Wrapper;
        public InvActions(@ControlsforPlayer wrapper) { m_Wrapper = wrapper; }
        public InputAction @Store => m_Wrapper.m_Inv_Store;
        public InputAction @Drop => m_Wrapper.m_Inv_Drop;
        public InputAction @PressPick => m_Wrapper.m_Inv_PressPick;
        public InputAction @HoldItem => m_Wrapper.m_Inv_HoldItem;
        public InputActionMap Get() { return m_Wrapper.m_Inv; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InvActions set) { return set.Get(); }
        public void SetCallbacks(IInvActions instance)
        {
            if (m_Wrapper.m_InvActionsCallbackInterface != null)
            {
                @Store.started -= m_Wrapper.m_InvActionsCallbackInterface.OnStore;
                @Store.performed -= m_Wrapper.m_InvActionsCallbackInterface.OnStore;
                @Store.canceled -= m_Wrapper.m_InvActionsCallbackInterface.OnStore;
                @Drop.started -= m_Wrapper.m_InvActionsCallbackInterface.OnDrop;
                @Drop.performed -= m_Wrapper.m_InvActionsCallbackInterface.OnDrop;
                @Drop.canceled -= m_Wrapper.m_InvActionsCallbackInterface.OnDrop;
                @PressPick.started -= m_Wrapper.m_InvActionsCallbackInterface.OnPressPick;
                @PressPick.performed -= m_Wrapper.m_InvActionsCallbackInterface.OnPressPick;
                @PressPick.canceled -= m_Wrapper.m_InvActionsCallbackInterface.OnPressPick;
                @HoldItem.started -= m_Wrapper.m_InvActionsCallbackInterface.OnHoldItem;
                @HoldItem.performed -= m_Wrapper.m_InvActionsCallbackInterface.OnHoldItem;
                @HoldItem.canceled -= m_Wrapper.m_InvActionsCallbackInterface.OnHoldItem;
            }
            m_Wrapper.m_InvActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Store.started += instance.OnStore;
                @Store.performed += instance.OnStore;
                @Store.canceled += instance.OnStore;
                @Drop.started += instance.OnDrop;
                @Drop.performed += instance.OnDrop;
                @Drop.canceled += instance.OnDrop;
                @PressPick.started += instance.OnPressPick;
                @PressPick.performed += instance.OnPressPick;
                @PressPick.canceled += instance.OnPressPick;
                @HoldItem.started += instance.OnHoldItem;
                @HoldItem.performed += instance.OnHoldItem;
                @HoldItem.canceled += instance.OnHoldItem;
            }
        }
    }
    public InvActions @Inv => new InvActions(this);

    // Actions
    private readonly InputActionMap m_Actions;
    private IActionsActions m_ActionsActionsCallbackInterface;
    private readonly InputAction m_Actions_Glide;
    private readonly InputAction m_Actions_Dive;
    private readonly InputAction m_Actions_GlideLeft;
    private readonly InputAction m_Actions_GlideRight;
    private readonly InputAction m_Actions_Jump;
    private readonly InputAction m_Actions_SwitchHat;
    private readonly InputAction m_Actions_ActivateHat;
    private readonly InputAction m_Actions_Snatch;
    public struct ActionsActions
    {
        private @ControlsforPlayer m_Wrapper;
        public ActionsActions(@ControlsforPlayer wrapper) { m_Wrapper = wrapper; }
        public InputAction @Glide => m_Wrapper.m_Actions_Glide;
        public InputAction @Dive => m_Wrapper.m_Actions_Dive;
        public InputAction @GlideLeft => m_Wrapper.m_Actions_GlideLeft;
        public InputAction @GlideRight => m_Wrapper.m_Actions_GlideRight;
        public InputAction @Jump => m_Wrapper.m_Actions_Jump;
        public InputAction @SwitchHat => m_Wrapper.m_Actions_SwitchHat;
        public InputAction @ActivateHat => m_Wrapper.m_Actions_ActivateHat;
        public InputAction @Snatch => m_Wrapper.m_Actions_Snatch;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterface != null)
            {
                @Glide.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnGlide;
                @Glide.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnGlide;
                @Glide.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnGlide;
                @Dive.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnDive;
                @Dive.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnDive;
                @Dive.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnDive;
                @GlideLeft.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnGlideLeft;
                @GlideLeft.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnGlideLeft;
                @GlideLeft.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnGlideLeft;
                @GlideRight.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnGlideRight;
                @GlideRight.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnGlideRight;
                @GlideRight.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnGlideRight;
                @Jump.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnJump;
                @SwitchHat.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSwitchHat;
                @SwitchHat.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSwitchHat;
                @SwitchHat.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSwitchHat;
                @ActivateHat.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnActivateHat;
                @ActivateHat.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnActivateHat;
                @ActivateHat.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnActivateHat;
                @Snatch.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSnatch;
                @Snatch.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSnatch;
                @Snatch.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSnatch;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Glide.started += instance.OnGlide;
                @Glide.performed += instance.OnGlide;
                @Glide.canceled += instance.OnGlide;
                @Dive.started += instance.OnDive;
                @Dive.performed += instance.OnDive;
                @Dive.canceled += instance.OnDive;
                @GlideLeft.started += instance.OnGlideLeft;
                @GlideLeft.performed += instance.OnGlideLeft;
                @GlideLeft.canceled += instance.OnGlideLeft;
                @GlideRight.started += instance.OnGlideRight;
                @GlideRight.performed += instance.OnGlideRight;
                @GlideRight.canceled += instance.OnGlideRight;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @SwitchHat.started += instance.OnSwitchHat;
                @SwitchHat.performed += instance.OnSwitchHat;
                @SwitchHat.canceled += instance.OnSwitchHat;
                @ActivateHat.started += instance.OnActivateHat;
                @ActivateHat.performed += instance.OnActivateHat;
                @ActivateHat.canceled += instance.OnActivateHat;
                @Snatch.started += instance.OnSnatch;
                @Snatch.performed += instance.OnSnatch;
                @Snatch.canceled += instance.OnSnatch;
            }
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);

    // Test
    private readonly InputActionMap m_Test;
    private ITestActions m_TestActionsCallbackInterface;
    private readonly InputAction m_Test_HealthTest;
    public struct TestActions
    {
        private @ControlsforPlayer m_Wrapper;
        public TestActions(@ControlsforPlayer wrapper) { m_Wrapper = wrapper; }
        public InputAction @HealthTest => m_Wrapper.m_Test_HealthTest;
        public InputActionMap Get() { return m_Wrapper.m_Test; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestActions set) { return set.Get(); }
        public void SetCallbacks(ITestActions instance)
        {
            if (m_Wrapper.m_TestActionsCallbackInterface != null)
            {
                @HealthTest.started -= m_Wrapper.m_TestActionsCallbackInterface.OnHealthTest;
                @HealthTest.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnHealthTest;
                @HealthTest.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnHealthTest;
            }
            m_Wrapper.m_TestActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HealthTest.started += instance.OnHealthTest;
                @HealthTest.performed += instance.OnHealthTest;
                @HealthTest.canceled += instance.OnHealthTest;
            }
        }
    }
    public TestActions @Test => new TestActions(this);

    // MenuActions
    private readonly InputActionMap m_MenuActions;
    private IMenuActionsActions m_MenuActionsActionsCallbackInterface;
    private readonly InputAction m_MenuActions_Quit;
    public struct MenuActionsActions
    {
        private @ControlsforPlayer m_Wrapper;
        public MenuActionsActions(@ControlsforPlayer wrapper) { m_Wrapper = wrapper; }
        public InputAction @Quit => m_Wrapper.m_MenuActions_Quit;
        public InputActionMap Get() { return m_Wrapper.m_MenuActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActionsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActionsActions instance)
        {
            if (m_Wrapper.m_MenuActionsActionsCallbackInterface != null)
            {
                @Quit.started -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnQuit;
                @Quit.performed -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnQuit;
                @Quit.canceled -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnQuit;
            }
            m_Wrapper.m_MenuActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
            }
        }
    }
    public MenuActionsActions @MenuActions => new MenuActionsActions(this);
    public interface IInvActions
    {
        void OnStore(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
        void OnPressPick(InputAction.CallbackContext context);
        void OnHoldItem(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnGlide(InputAction.CallbackContext context);
        void OnDive(InputAction.CallbackContext context);
        void OnGlideLeft(InputAction.CallbackContext context);
        void OnGlideRight(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSwitchHat(InputAction.CallbackContext context);
        void OnActivateHat(InputAction.CallbackContext context);
        void OnSnatch(InputAction.CallbackContext context);
    }
    public interface ITestActions
    {
        void OnHealthTest(InputAction.CallbackContext context);
    }
    public interface IMenuActionsActions
    {
        void OnQuit(InputAction.CallbackContext context);
    }
}

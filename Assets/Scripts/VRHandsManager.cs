using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class VRHandsManager : MonoBehaviour
{
    public Animator handanimator;

    public InputActionReference gripButton;

    private void Awake()
    {
        handanimator = this.GetComponent<Animator>();
    }
    void Start()
    {
        gripButton.action.started += Grip_Started;
        gripButton.action.canceled += Grip_Released;
    }

    private void Grip_Released(InputAction.CallbackContext obj)
    {
        Released();
    }

    private void Grip_Started(InputAction.CallbackContext obj)
    {
        Gripped();
    }

    public void Gripped()
    {
        handanimator.SetBool("isGrip", true);
    }

    public void Released()
    {
        handanimator.SetBool("isGrip", false);
    }
}

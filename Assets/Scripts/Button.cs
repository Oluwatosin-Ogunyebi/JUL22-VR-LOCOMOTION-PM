using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    //public Transform button;
    //public Transform buttonPressed;
    //public Transform buttonReleased;

    public Transform button, buttonPressed, buttonReleased;

    public UnityEvent onButtonPressed;
    public UnityEvent onButtonReleased;


    public void OnPressed()
    {
        button.position = buttonPressed.position;
        onButtonPressed.Invoke();
    }

    public void OnReleased()
    {
        button.position = buttonReleased.position;
        onButtonReleased.Invoke();
    }
}

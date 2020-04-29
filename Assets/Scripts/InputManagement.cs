using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagement : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField]
    private KeyCode Forward;
    [SerializeField]
    private KeyCode Back;
    [SerializeField]
    private KeyCode Right;
    [SerializeField]
    private KeyCode Left;
#pragma warning restore 0649

    public event Action OnForwardKeyPressed;
    public event Action OnBackKeyPressed;
    public event Action OnRightKeyPressed;
    public event Action OnLeftKeyPressed;
    void FixedUpdate()
    {
        if (Input.GetKey(Forward))
            OnForwardKeyPressed();

        if (Input.GetKey(Back))
            OnBackKeyPressed();

        if (Input.GetKey(Left))
            OnLeftKeyPressed();

        if (Input.GetKey(Right))
            OnRightKeyPressed();
    }
}

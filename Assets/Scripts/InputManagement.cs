using System;
using NaughtyAttributes;
using UnityEngine;

public class InputManagement : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField]
    [InputAxis]
    private string Horizontal;

    [SerializeField]
    [InputAxis]
    private string Vertical;

#pragma warning restore 0649
    /// <summary>
    /// 1.float horizontal
    /// 2.float vertial
    /// </summary>

    public event Action<float,  float> OnAxisInput;
   
    void FixedUpdate()
    {
        OnAxisInput?.Invoke(Input.GetAxisRaw(Horizontal), Input.GetAxisRaw(Vertical));
    }
}

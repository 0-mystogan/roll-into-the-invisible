using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
#pragma warning disable 0649

    [SerializeField]
    [Header("Input Management")]
    private InputManagement InputManagement;

    [Header("Ball Speed")]
    [Range(0, 20)]
    [SerializeField]
    private float Speed;
#pragma warning restore 0649    

    #region Initialization
    private void Start()
    {
        InputManagement.OnForwardKeyPressed += InputManagement_OnForwardKeyPressed;
        InputManagement.OnBackKeyPressed += InputManagement_OnBackKeyPressed;
        InputManagement.OnRightKeyPressed += InputManagement_OnRightKeyPressed;
        InputManagement.OnLeftKeyPressed += InputManagement_OnLeftKeyPressed;
    }

    private void OnDestroy()
    {
        InputManagement.OnForwardKeyPressed -= InputManagement_OnForwardKeyPressed;
        InputManagement.OnBackKeyPressed -= InputManagement_OnBackKeyPressed;
        InputManagement.OnRightKeyPressed -= InputManagement_OnRightKeyPressed;
        InputManagement.OnLeftKeyPressed -= InputManagement_OnLeftKeyPressed;
    }
    #endregion

    private void FixedUpdate()
    {
        if(this.GetComponent<Rigidbody>().position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
    private void InputManagement_OnLeftKeyPressed()
    {
        this.GetComponent<Rigidbody>().AddForce(Vector3.left * Speed, ForceMode.Acceleration);
    }

    private void InputManagement_OnRightKeyPressed()
    {
        this.GetComponent<Rigidbody>().AddForce(Vector3.right * Speed, ForceMode.Acceleration);
    }

    private void InputManagement_OnBackKeyPressed()
    {
        this.GetComponent<Rigidbody>().AddForce(Vector3.back * Speed, ForceMode.Acceleration);
    }

    private void InputManagement_OnForwardKeyPressed()
    {
        this.GetComponent<Rigidbody>().AddForce(Vector3.forward * Speed, ForceMode.Acceleration);
    }

}

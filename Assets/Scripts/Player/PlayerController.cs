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
        InputManagement.OnAxisInput += InputManagement_OnAxisInput;

    }

    private void OnDestroy()
    {
        InputManagement.OnAxisInput -= InputManagement_OnAxisInput;
    }


    #endregion

    private void InputManagement_OnAxisInput(float horizontal, float veritcal)
    {

        this.GetComponent<Rigidbody>().AddForce(horizontal * Speed, 0, veritcal* Speed, ForceMode.Acceleration);
    }

    private void FixedUpdate()
    {
        if(this.GetComponent<Rigidbody>().position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

}

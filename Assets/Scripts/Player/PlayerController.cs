using NaughtyAttributes;
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

    [SerializeField]
    [ReadOnly]
    private bool IsGrounded;
#pragma warning restore 0649
    private Rigidbody rb;
    public JumpHandler Jump;
    #region Initialization
    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
            Debug.Log("On the goround");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = false;
            Debug.Log("NOT On the goround");
        }
    }

    private void FixedUpdate()
    {
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

        if(IsGrounded)
            Jump.Jump();
    }

}

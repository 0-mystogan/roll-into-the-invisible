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
    private bool isGrounded;
#pragma warning restore 0649
    private Rigidbody rb;
    #region Initialization
    private void Start()
    {
        isGrounded = true;
        rb = this.GetComponent<Rigidbody>();
        InputManagement.OnAxisInput += InputManagement_OnAxisInput;
        InputManagement.OnJumpInput += InputManagement_OnJumpInput;
    }

    private void OnDestroy()
    {
        InputManagement.OnAxisInput -= InputManagement_OnAxisInput;
    }

    #endregion

  
    private void InputManagement_OnAxisInput(float horizontal, float veritcal)
    {
        if(isGrounded)
        rb.AddForce(horizontal * Speed, 0, veritcal * Speed, ForceMode.Acceleration);
        else
            rb.AddForce(horizontal * (Speed - 5), 0, veritcal * (Speed - 5), ForceMode.Acceleration);

    }

    private void InputManagement_OnJumpInput(float jump)
    {
        if ( jump > 0 && isGrounded)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }

    private void FixedUpdate()
    {
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

    }

}

using UnityEngine;

public class JumpHandler : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField]
    private Rigidbody rb;

    [Header("High Jump Multiplier")]
    [Range(0, 5)]
    [SerializeField]
    private float HighJumpMultiplier;

    [Header("Low Jump Multiplier")]
    [Range(0, 5)]
    [SerializeField]
    private float LowJumpMultiplier;

    [SerializeField]
    [Range(20, 200)]
    private int JumpSpeed = 25;

#pragma warning restore 0649


    public void Jump()
    {
        if (Input.GetButton("Jump"))
        {
            rb.velocity += Vector3.up * JumpSpeed * Time.deltaTime;

            if (rb.velocity.y < 0)
                rb.velocity += Vector3.up * Physics.gravity.y * HighJumpMultiplier * Time.deltaTime;
        }
        else if (!Input.GetButton("Jump") && rb.velocity.y > 0)
                rb.velocity += Vector3.up * Physics.gravity.y * LowJumpMultiplier * Time.deltaTime;
    }
}

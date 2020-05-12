using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField]
    private Vector3 v3Force;
#pragma warning restore 0649

    private void FixedUpdate()
    {
        this.GetComponent<Rigidbody>().velocity += v3Force;
    }
}

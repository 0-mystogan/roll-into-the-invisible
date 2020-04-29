using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 2f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        if(target != null)
        {
            Vector3 position = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, position, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;

            transform.LookAt(target);
        }
        
    }
}

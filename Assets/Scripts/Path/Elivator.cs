using UnityEngine;

public class Elivator : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = this.GetComponentInParent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            animator.SetTrigger("GoUp");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steps : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField]
    private GameObject step;
#pragma warning restore 0649

    
    private void OnCollisionEnter(Collision collision)
    {
        if (step.GetComponent<Renderer>().enabled == false)
            step.GetComponent<Renderer>().enabled = true;
    }

}

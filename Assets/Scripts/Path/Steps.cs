using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Steps : MonoBehaviour
{
#pragma warning disable 0649

    [SerializeField]
    private Material Original;
#pragma warning restore 0649



    private void OnCollisionEnter(Collision collision)
    {
            this.GetComponent<MeshRenderer>().enabled = true;
            this.GetComponent<MeshRenderer>().material = Original;
            Constants.IndexOfObject =  transform.GetSiblingIndex();
    }

}

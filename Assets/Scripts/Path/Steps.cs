using UnityEngine;

public class Steps : MonoBehaviour
{
//#pragma warning disable 0649
//    [SerializeField]
//    private GameObject step;
//#pragma warning restore 0649

    
    private void OnCollisionEnter(Collision collision)
    {
        if (this.GetComponent<Renderer>().enabled == false)
            this.GetComponent<Renderer>().enabled = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGem : MonoBehaviour
{
    private void OnTriggerEnter(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            if(this.GetComponentInChildren<Renderer>().enabled == false)
                this.GetComponentInChildren<Renderer>().enabled = true;
        }
    }

}

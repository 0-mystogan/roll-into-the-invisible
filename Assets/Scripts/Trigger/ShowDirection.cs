using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowDirection : MonoBehaviour
{
#pragma warning disable 0649

    [SerializeField]
    private Image Image;
#pragma warning restore 0649



    private void OnTriggerEnter(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            if(Image.enabled == false)
                Image.enabled = true;
        }
    }

    private void OnTriggerExit(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            if(Image.enabled == true)
                Image.enabled = false;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class OutlineNextStep : MonoBehaviour
{
#pragma warning disable 0649

    private List<MeshRenderer> Renderer;
    [SerializeField]
    private Material Silhouette;
#pragma warning restore 0649



    private void Start()
    {
        Renderer = gameObject.GetComponentsInChildren<MeshRenderer>().ToList();
    }

    private void Update()
    {
        ShowSilhouette();
    }

    private void ShowSilhouette()
    {
        if((Constants.IndexOfObject >= 0 && Constants.IndexOfObject < Renderer.Count) && Renderer[Constants.IndexOfObject].enabled)
        {
            Renderer[Constants.IndexOfObject + 1].enabled = true;
            Renderer[Constants.IndexOfObject + 1].material = Silhouette;
        }
    }

}

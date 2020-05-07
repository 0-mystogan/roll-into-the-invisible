using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OnDestroy : MonoBehaviour
{
    private float delayDestroy = 0.3f;
#pragma warning disable 0649
    [SerializeField]
    private TextMeshProUGUI Score;
#pragma warning restore 0649
 
    private void OnTriggerEnter(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            Constants.ScoreCounter++;
            Score.SetText(Constants.ScoreCounter.ToString());
            if (this.gameObject != null)
                Destroy(this.gameObject, delayDestroy);
            
        }
        Debug.Log(Constants.ScoreCounter);
    }
}

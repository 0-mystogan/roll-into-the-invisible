using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    private float restartDelay = 1f;
   public void GameOver()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        Constants.IndexOfObject = 0;
        Constants.ScoreCounter = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

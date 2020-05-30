using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManu : MonoBehaviour
{
    public void FirstLevel()
    {
        SceneManager.LoadScene(1);
    } 
    public void SecondLevel()
    {
        SceneManager.LoadScene(2);
    } 
    public void ThirdLevel()
    {
        SceneManager.LoadScene(3);
    }
}

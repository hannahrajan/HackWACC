using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        SceneManager.LoadScene("Tips");
    }

    public void QuitGame()
    {
       Application.Quit();
        Debug.Log("Game closed.");
    }
}


using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonToggle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnHome()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Next()
    {
        SceneManager.LoadScene("Scene2");
    }
}

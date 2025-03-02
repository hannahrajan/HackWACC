using UnityEngine;
using UnityEngine.SceneManagement;

public class SubmitButton : MonoBehaviour
{

    [SerializeField] private string newGameLevel = "game"; // TODO: whatever the actual game scene is called 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SubmitButtonManager() {
        SceneManager.LoadScene(newGameLevel);
    }
}

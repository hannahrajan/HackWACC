using UnityEngine;
using UnityEngine.UI;

public class YesClicked : MonoBehaviour
{
    public Color wantedColor;
    // public Color oldColor;
    public Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeButtonColor() {
        ColorBlock cb = button.colors;
        cb.normalColor = wantedColor;
        cb.highlightedColor = wantedColor;
        cb.pressedColor = wantedColor;
        button.colors = cb;
    }

    // public void changeBackButtonColor() {
    //     ColorBlock c = button.colors;
    //     c.normalColor = oldColor;
    //     c.highlightedColor = oldColor;
    //     c.pressedColor = oldColor;
    //     button.colors = c;
    // }
}

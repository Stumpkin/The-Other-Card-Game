using UnityEngine;
using TMPro;
public class SampleUI : MonoBehaviour
{
    private TextMeshProUGUI someText;
    void Start()
    {
        someText = GetComponent<TextMeshProUGUI>();
        someText.text = "";
    }

    public void setElementText(int an, string text)
    {
        string number = an.ToString();
        someText.text = (number + " " + text); 
    }

    public void setText(string text)
    {
        someText.text = text;
    }

    public void resetText()
    {
        someText.text = "";
    }

    public void addText(string placement)
    {
        someText.text += placement;
    }

    public string getText()
    {
        return someText.text;
    }
}

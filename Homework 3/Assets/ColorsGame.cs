using TMPro;
using UnityEngine;

public class ColorsGame : MonoBehaviour
{
    public Light cyanLight;
    public Light magentaLight;
    public Light yellowLight;
    public TextMeshProUGUI text;
    private void Start()
    {
        cyanLight = GetComponent<Light>();
        magentaLight = GetComponent<Light>();
        yellowLight = GetComponent<Light>();

        TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
        //Set wrong colors at start
        cyanLight.color = Color.yellow;
        magentaLight.color = Color.cyan;
        yellowLight.color = Color.magenta;
    }

    private void Update()
    {
        if (cyanLight.color == Color.cyan && magentaLight.color == Color.magenta && yellowLight.color == Color.yellow)
        {
            //change text "Good job" here
            text.text = "Good job!";
        }
    }
}

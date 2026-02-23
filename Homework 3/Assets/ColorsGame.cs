using TMPro;
using UnityEngine;

public class ColorsGame : MonoBehaviour
{
    public Light cyanLight;
    public Light magentaLight;
    public Light yellowLight;
    public TextMeshProUGUI message;
    private void Start()
    {

        cyanLight = cyanLight.GetComponent<Light>();
        magentaLight = magentaLight.GetComponent<Light>();
        yellowLight = yellowLight.GetComponent<Light>();

        message = message.GetComponent<TextMeshProUGUI>();
        //Set wrong colors at start
        cyanLight.enabled = true;
        cyanLight.color = Color.yellow;
        magentaLight.enabled = true;
        magentaLight.color = Color.cyan;
        yellowLight.enabled = true;
        yellowLight.color = Color.magenta;
    }

    private void Update()
    {
        if (cyanLight.color == Color.cyan && magentaLight.color == Color.magenta && yellowLight.color == Color.yellow)
        {
            //change text "Good job" here
            message.text = "Good job!";
        }
    }
}

using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Events;

public class ButtonInteraction : MonoBehaviour
{
    public GameObject button;
    public Light light;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    //AudioSource sound;
    bool isPressed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //sound = GetComponent<AudioSource>();
        //light = GetComponent<Light>();
        
        //light.enabled = false;
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0,0.008f,0);
            presser = other.gameObject;
            onPress.Invoke();
            //sound.Play();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }
    public void ChangeLightColor()
    {
        /*
        if (light.color == Color.white)
        {
            light.color = Color.red;
        }
        else if (light.color == Color.red)
        {
            light.color = Color.white;
        }*/
        if (light.color == Color.cyan)
        {
            light.color = Color.magenta;
        }
        else if (light.color == Color.magenta)
        {
            light.color = Color.yellow;
        }
        else if (light.color == Color.yellow)
        {
            light.color = Color.cyan;
        }
    }

    public void TurnOnLight()
    {
        if (!light.enabled)
        {
            light.enabled = true;
        } else
        {
            light.enabled = false;
        }
    }
}

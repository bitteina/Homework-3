using JetBrains.Annotations;
using UnityEngine;

public class Consumable : MonoBehaviour
{
    public GameObject full;
    public GameObject eaten;

    public bool IsFinished = false;

    private void Start()
    {
        full.SetActive(true);
        eaten.SetActive(false);
    }
    public void Consume()
    { 
        if(!IsFinished)
        {
            full.SetActive(false);
            eaten.SetActive(true);
            IsFinished = true;
        }
    }
}

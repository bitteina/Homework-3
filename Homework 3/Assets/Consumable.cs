using JetBrains.Annotations;
using UnityEngine;

public class Consumable : MonoBehaviour
{
    [SerializeField] GameObject[] portions;
    [SerializeField] int index = 0;

    public bool IsFinished => index == portions.Length;

    private void Start()
    {
        SetVisuals();   
    }

    public void Consume()
    { 
        if(!IsFinished)
        {
            index++;
        }
    }

    void SetVisuals()
    {
        for (int i = 0; i > portions.Length; i++)
        {
            portions[i].SetActive(i == index);
        }
    }
}

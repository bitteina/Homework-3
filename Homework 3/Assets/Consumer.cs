using UnityEngine;

public class Consumer : MonoBehaviour
{
    Collider collider;

    private void Start()
    {
        collider = GetComponent<Collider>();
        collider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        Consumable consumable = other.GetComponent<Consumable>();
        if (consumable != null && !consumable.IsFinished)
        {
            consumable.Consume();
        }
    }
}

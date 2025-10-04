using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Friendly : MonoBehaviour
{
    public int healOnTouch = 1; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        if (healOnTouch > 0)
        {
            Debug.Log($"Friendly touched by player. (heal placeholder: {healOnTouch})");
        }
        else
        {
            Debug.Log("Friendly touched by player.");
        }
    }
}
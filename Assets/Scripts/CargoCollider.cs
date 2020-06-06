using UnityEngine;
using UnityEngine.UI;
using System;

public class CargoCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cargo"))
        {
            FindObjectOfType<AudioManager>().Play("pickupcargo");
            score.scoreValue += 1;
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}

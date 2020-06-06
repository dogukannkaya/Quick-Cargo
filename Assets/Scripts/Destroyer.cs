using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public HealthBar healtBar;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cargo"))
        {
            FindObjectOfType<AudioManager>().Play("wrong");
            Destroy(other.gameObject);
            healtBar.TakeDamage();
        }
    }
}

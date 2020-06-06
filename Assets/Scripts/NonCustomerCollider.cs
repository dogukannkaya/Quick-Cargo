using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class NonCustomerCollider : MonoBehaviour
{
    public HealthBar healthBar;
    public float lifeTime = 3;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (gameObject.name == "NonCustomer(Clone)")
        {
            Destroy(GameObject.Find("NonCustomer(Clone)"), lifeTime);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cargo"))
        {
            FindObjectOfType<AudioManager>().Play("wrong");
            healthBar.TakeDamage();
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}

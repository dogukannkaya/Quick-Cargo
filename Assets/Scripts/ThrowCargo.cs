using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ThrowCargo : MonoBehaviour
{
    public float offset = -90;
    public Transform throwPoint;
    public GameObject cargoPrefab;
    public Text scoreText;

    private void Start()
    {
        scoreText.text = 0.ToString();
   
    }

    void Update()
    {
        Touch touch = Input.GetTouch(0);
        Vector3 difference = Camera.main.ScreenToWorldPoint(touch.position) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (EventSystem.current.IsPointerOverGameObject(touch.fingerId))
            {
                return;
            }

            if (PauseScreen.GameIsPaused == false && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        Instantiate(cargoPrefab, throwPoint.position, throwPoint.rotation);
    }
}

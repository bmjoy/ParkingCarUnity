using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            Destroy(collision.gameObject);
        }
        print("OnTriggerEnter2D");
    }
}

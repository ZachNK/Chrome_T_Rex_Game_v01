using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusPool : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cactus")
        {
            Destroy(collision.gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fz : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "theo")
        {
            collision.transform.Translate(Vector2.up * Time.deltaTime);
        }
    }
}

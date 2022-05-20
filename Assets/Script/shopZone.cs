using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopZone : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {        
        if (collision.gameObject.name == "Player")
        {
            if (Input.GetKey("k"))
            {
                Debug.Log("Shop is open");
            }
        }
    }
}

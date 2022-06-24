using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportation : MonoBehaviour
{
    public Transform spawnTp, spawnTpShop;
    public int lstTp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (lstTp)
        {
            //effet de heal
            case 1:
                spawnZone1();
                break;
            //effet de speed
            case 2:
                spawnShop();
                break;
            default:

                break;
        }

        void spawnZone1()
        {
            if (collision.gameObject.name == "Player")
            {
                playerController.instance.transform.position = spawnTp.position;
            }
        }

        void spawnShop()
        {
            if (collision.gameObject.name == "Player")
            {
                playerController.instance.transform.position = spawnTpShop.position;
            }
        }

        
    }
}

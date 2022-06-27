using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportation : MonoBehaviour
{
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
            case 3:
                spawnNextStage();
                break;

            default:

                break;
        }

        void spawnZone1()
        {
            if (collision.gameObject.name == "Player")
            {
                playerController.instance.transform.position = new Vector3(-70, -5, 0);
            }
        }

        void spawnShop()
        {
            if (collision.gameObject.name == "Player")
            {
                playerController.instance.transform.position = new Vector3(-23, -3, 0);
            }
        }

        void spawnNextStage()
        {
            if (collision.gameObject.name == "Player")
            {
                //coord
                playerController.instance.transform.position = new Vector3(-58, -57, 0);
            }
        }
        
    }
}

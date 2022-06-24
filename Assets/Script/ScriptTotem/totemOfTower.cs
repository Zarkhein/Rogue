using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class totemOfTower : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField]
    public float currentLife = 50;

    [Header("Loots")]
    [SerializeField]
    public int dropMoney;

    [Header("Dev")]
    [SerializeField]
    public Text textMoneyPlayer;
    private int moneyRand;


    void Start()
    {
        moneyRand = Random.Range(0, dropMoney);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "fireball(Clone)")
        {
            Destroy(collision.gameObject);
            currentLife -= playerController.instance.damage;
            if (currentLife <= 0)
            {
                Destroy(gameObject);
                playerController.instance.moneyPlayer += moneyRand;
                textMoneyPlayer.text = playerController.instance.moneyPlayer.ToString();
                scriptWave.instance.totemLive -= 1;
            }
        }

        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Le boss touche le joueur");
            playerController.instance.currentHealth -= 1;
        }
    }
}


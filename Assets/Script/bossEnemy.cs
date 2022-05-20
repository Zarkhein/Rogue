using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossEnemy : MonoBehaviour
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
    public float offSet = -90;
    public int Vitesse;

    public Transform player;
    private Vector2 mouvement;
    
    // Start is called before the first frame update
    void Start()
    {
        moneyRand = Random.Range(0, dropMoney);
    }

    // Update is called once per frame
    void Update()
    {        
        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle + offSet);
        mouvement = direction;
        transform.Translate(Vector2.up * Vitesse * Time.deltaTime);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "fireball(Clone)")
        {
            Destroy(collision.gameObject);
            currentLife -= playerController.instance.damage;
            if(currentLife <= 0)
            {
                Destroy(gameObject);                
                playerController.instance.moneyPlayer += moneyRand;
                textMoneyPlayer.text = playerController.instance.moneyPlayer.ToString();
            }
        }
        if(collision.gameObject.name == "Player")
        {
            Debug.Log("Le boss touche le joueur");
            playerController.instance.currentHealth -= 1;
        }
    }
}

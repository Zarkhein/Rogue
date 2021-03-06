using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject shopMenu;
    public Button btnShopMoney, btnShopHealth, btnShopRange, btnShopExit;
    public Text textMoneyPlayer;

    public string txtPlayer;

    private void Start()
    {
        shopMenu.SetActive(false);
        btnShopMoney.onClick.AddListener(buyMoney);
        btnShopHealth.onClick.AddListener(buyHealth);
        btnShopRange.onClick.AddListener(buyRange);
        btnShopExit.onClick.AddListener(shopExit);
    }

    private void shopExit()
    {
        shopMenu.SetActive(false);
    }

    private void Update()
    {
        openShop();
    }

    void buyMoney()
    {
        
        playerController.instance.moneyPlayer += 50;
        textMoneyPlayer.text = playerController.instance.moneyPlayer.ToString();
        Debug.Log(playerController.instance.moneyPlayer);
    }

    void buyRange()
    {
        playerController.instance.range += 1;
        playerController.instance.moneyPlayer -= 50;
        textMoneyPlayer.text = playerController.instance.moneyPlayer.ToString();
    }

    void buyHealth()
    {
        playerController.instance.currentHealth += 1;
        playerController.instance.moneyPlayer -= 150;
        textMoneyPlayer.text = playerController.instance.moneyPlayer.ToString();
    }


    void openShop()
    {
        if (Input.GetKey("p"))
        {
            shopMenu.SetActive(true);
        }
    }

}

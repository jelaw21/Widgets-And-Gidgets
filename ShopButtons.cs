using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButtons : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject workToShiniesPanel;
    public GameObject shiniesToWorkPanel;
    public GameObject upgradesPanel;

    public GameObject workToShiniesBtn;
    public GameObject shiniesToWorkBtn;
    public GameObject upgradeButton;
   
    public GameObject multOneBtn;
    public GameObject multFiveBtn;
    public GameObject multTenBtn;
    public GameObject multFiftyBtn;

    public GameObject multOneBtn2;
    public GameObject multFiveBtn2;
    public GameObject multTenBtn2;
    public GameObject multFiftyBtn2;

    public Sprite normal;
    public Sprite selected;

    public AudioSource normalClick;
       

    void Start()
    {
        shopPanel.SetActive(false);

    }

    public void showShop()
    {
        normalClick.Play();
        shopPanel.SetActive(true);
        ShopBuy.multiplier = 1;
        ShopSell.multiplier = 1;
        multOneBtn.GetComponent<Image>().sprite = selected;
        multOneBtn2.GetComponent<Image>().sprite = selected;
        multFiveBtn.GetComponent<Image>().sprite = normal;
        multFiveBtn2.GetComponent<Image>().sprite = normal;
        multTenBtn.GetComponent<Image>().sprite = normal;
        multTenBtn2.GetComponent<Image>().sprite = normal;
        multFiftyBtn.GetComponent<Image>().sprite = normal;
        multFiftyBtn2.GetComponent<Image>().sprite = normal;

        showWorktoShinies();

    }

    public void exitShop()
    {
        normalClick.Play();
        shopPanel.SetActive(false);
    }

    public void showWorktoShinies()
    {
        normalClick.Play();
        workToShiniesPanel.SetActive(true);
        shiniesToWorkPanel.SetActive(false);
        upgradesPanel.SetActive(false);

        workToShiniesBtn.GetComponent<Image>().sprite = selected;
        shiniesToWorkBtn.GetComponent<Image>().sprite = normal;
        upgradeButton.GetComponent<Image>().sprite = normal;

    }

    public void showShiniestoWork()
    {
        normalClick.Play();
        workToShiniesPanel.SetActive(false);
        shiniesToWorkPanel.SetActive(true);
        upgradesPanel.SetActive(false);

        workToShiniesBtn.GetComponent<Image>().sprite = normal;
        shiniesToWorkBtn.GetComponent<Image>().sprite = selected;
        upgradeButton.GetComponent<Image>().sprite = normal;
    }

    public void showUpgrades()
    {
        normalClick.Play();
        workToShiniesPanel.SetActive(false);
        shiniesToWorkPanel.SetActive(false);
        upgradesPanel.SetActive(true);

        workToShiniesBtn.GetComponent<Image>().sprite = normal;
        shiniesToWorkBtn.GetComponent<Image>().sprite = normal;
        upgradeButton.GetComponent<Image>().sprite = selected;
    }

    public void multiplyBy1()
    {
        normalClick.Play();
        ShopBuy.multiplier = 1;
        ShopSell.multiplier = 1;

        multOneBtn.GetComponent<Image>().sprite = selected;
        multFiveBtn.GetComponent<Image>().sprite = normal;
        multTenBtn.GetComponent<Image>().sprite = normal;
        multFiftyBtn.GetComponent<Image>().sprite = normal;

        multOneBtn2.GetComponent<Image>().sprite = selected;
        multFiveBtn2.GetComponent<Image>().sprite = normal;
        multTenBtn2.GetComponent<Image>().sprite = normal;
        multFiftyBtn2.GetComponent<Image>().sprite = normal;
    }

    public void multiplyBy5()
    {
        normalClick.Play();
        ShopBuy.multiplier = 5;
        ShopSell.multiplier = 5;

        multOneBtn.GetComponent<Image>().sprite = normal;
        multFiveBtn.GetComponent<Image>().sprite = selected;
        multTenBtn.GetComponent<Image>().sprite = normal;
        multFiftyBtn.GetComponent<Image>().sprite = normal;

        multOneBtn2.GetComponent<Image>().sprite = normal;
        multFiveBtn2.GetComponent<Image>().sprite = selected;
        multTenBtn2.GetComponent<Image>().sprite = normal;
        multFiftyBtn2.GetComponent<Image>().sprite = normal;
    }

    public void multiplyBy10()
    {
        normalClick.Play();
        ShopBuy.multiplier = 10;
        ShopSell.multiplier = 10;

        multOneBtn.GetComponent<Image>().sprite = normal;
        multFiveBtn.GetComponent<Image>().sprite = normal;
        multTenBtn.GetComponent<Image>().sprite = selected;
        multFiftyBtn.GetComponent<Image>().sprite = normal;

        multOneBtn2.GetComponent<Image>().sprite = normal;
        multFiveBtn2.GetComponent<Image>().sprite = normal;
        multTenBtn2.GetComponent<Image>().sprite = selected;
        multFiftyBtn2.GetComponent<Image>().sprite = normal;
    }

    public void multiplyBy50()
    {
        normalClick.Play();
        ShopBuy.multiplier = 50;
        ShopSell.multiplier = 50;

        multOneBtn.GetComponent<Image>().sprite = normal;
        multFiveBtn.GetComponent<Image>().sprite = normal;
        multTenBtn.GetComponent<Image>().sprite = normal;
        multFiftyBtn.GetComponent<Image>().sprite = selected;

        multOneBtn2.GetComponent<Image>().sprite = normal;
        multFiveBtn2.GetComponent<Image>().sprite = normal;
        multTenBtn2.GetComponent<Image>().sprite = normal;
        multFiftyBtn2.GetComponent<Image>().sprite = selected;
    }
}

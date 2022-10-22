using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSell : MonoBehaviour
{
    public static int multiplier = 1;
    public static int material = 1;
    public int widgetPrice = 2;
    public int gidgetPrice = 4;
    public int doodadPrice = 10;
    public int whizbangPrice = 16;
    public int whatzitPrice = 35;
    public int thingamajigPrice = 45;
    public int gizmoPrice = 62;
    public int gadgetPrice = 135;

    public GameObject widgetDisplayAmount;
    public GameObject widgetPriceAmount;
    public GameObject widgetSellButton;

    public GameObject gidgetDisplayAmount;
    public GameObject gidgetPriceAmount;
    public GameObject gidgetSellButton;

    public GameObject doodadDisplayAmount;
    public GameObject doodadPriceAmount;
    public GameObject doodadSellButton;

    public GameObject whizbangDisplayAmount;
    public GameObject whizbangPriceAmount;
    public GameObject whizbangSellButton;

    public GameObject whatzitDisplayAmount;
    public GameObject whatzitPriceAmount;
    public GameObject whatzitSellButton;

    public GameObject thingamajigDisplayAmount;
    public GameObject thingamajigPriceAmount;
    public GameObject thingamajigSellButton;

    public GameObject gizmoDisplayAmount;
    public GameObject gizmoPriceAmount;
    public GameObject gizmoSellButton;

    public GameObject gadgetDisplayAmount;
    public GameObject gadgetPriceAmount;
    public GameObject gadgetSellButton;

    public AudioSource shinySound;

    void Update()
    {
        updateShopButton(widgetDisplayAmount, widgetPriceAmount, widgetPrice, GlobalData.widgetCount, widgetSellButton);
        updateShopButton(gidgetDisplayAmount, gidgetPriceAmount, gidgetPrice, GlobalData.gidgetCount, gidgetSellButton);
        updateShopButton(doodadDisplayAmount, doodadPriceAmount, doodadPrice, GlobalData.doodadCount, doodadSellButton);
        updateShopButton(whizbangDisplayAmount, whizbangPriceAmount, whizbangPrice, GlobalData.whizbangCount, whizbangSellButton);
        updateShopButton(whatzitDisplayAmount, whatzitPriceAmount, whatzitPrice, GlobalData.whatzitCount, whatzitSellButton);
        updateShopButton(thingamajigDisplayAmount, thingamajigPriceAmount, thingamajigPrice, GlobalData.thingamajigCount, thingamajigSellButton);
        updateShopButton(gizmoDisplayAmount, gizmoPriceAmount, gizmoPrice, GlobalData.gizmoCount, gizmoSellButton);
        updateShopButton(gadgetDisplayAmount, gadgetPriceAmount, gadgetPrice, GlobalData.gadgetCount, gadgetSellButton);

    }

    

    public void sellWidget()
    {
        shinySound.Play();
        GlobalData.widgetCount -= multiplier;
        GlobalData.shinyCount += (int)Mathf.Pow(2,(material-1)) * widgetPrice * multiplier;
    }

    public void sellGidget()
    {
        shinySound.Play();
        GlobalData.gidgetCount -= multiplier;
        GlobalData.shinyCount += (int)Mathf.Pow(2, (material - 1)) * gidgetPrice * multiplier;
    }
    public void sellDoodad()
    {
        shinySound.Play();
        GlobalData.doodadCount -= multiplier;
        GlobalData.shinyCount += (int)Mathf.Pow(2, (material - 1)) * doodadPrice * multiplier;
    }
    public void sellWhizbang()
    {
        shinySound.Play();
        GlobalData.whizbangCount -= multiplier;
        GlobalData.shinyCount += (int)Mathf.Pow(2, (material - 1)) * whizbangPrice * multiplier;
    }
    public void sellWhatzit()
    {
        shinySound.Play();
        GlobalData.whatzitCount -= multiplier;
        GlobalData.shinyCount += (int)Mathf.Pow(2, (material - 1)) * whatzitPrice * multiplier;
    }
    public void sellThingamajig()
    {
        shinySound.Play();
        GlobalData.thingamajigCount -= multiplier;
        GlobalData.shinyCount += (int)Mathf.Pow(2, (material - 1)) * thingamajigPrice * multiplier;
    }
    public void sellGizmo()
    {
        shinySound.Play();
        GlobalData.gizmoCount -= multiplier;
        GlobalData.shinyCount += (int)Mathf.Pow(2, (material - 1)) * gizmoPrice * multiplier;
    }
    public void sellGadget()
    {
        shinySound.Play();
        GlobalData.gadgetCount -= multiplier;
        GlobalData.shinyCount += (int)Mathf.Pow(2, (material - 1)) * gadgetPrice * multiplier;
    }

    public void updateShopButton(GameObject displayAmount, GameObject priceAmount, int price, int count, GameObject button)
    {
        displayAmount.GetComponent<Text>().text = (ShopSell.multiplier).ToString();
        priceAmount.GetComponent<Text>().text = ((int)Mathf.Pow(2, material-1) * price * multiplier).ToString();
        if (count < multiplier)
        {
            button.GetComponent<Button>().interactable = false;
        }
        else
            button.GetComponent<Button>().interactable = true;
    }
}

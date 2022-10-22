using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopBuy : MonoBehaviour
{
    // Start is called before the first frame update

    public static int multiplier = 1;
    public static int rod = 12;
    public static int rodCost = 1;
    public static int plate = 5;    
    public static int plateCost = 1;
    public static int spring = 6;
    public static int springCost = 2;
    public static int gear = 4;
    public static int gearCost = 2;
    public static int lever = 3;
    public static int leverCost = 4;
    public static int sprocket = 3;
    public static int sprocketCost = 6;
    public static int widget = 1;
    public static int widgetCost = 12;
    public static int gidget = 1;
    public static int gidgetCost = 24;

    public GameObject rodAmountDisplay;    
    public GameObject rodCostDisplay;
    public GameObject rodBuyBtn;

    public GameObject plateAmountDisplay;
    public GameObject plateCostDisplay;
    public GameObject plateBuyBtn;

    public GameObject springAmountDisplay;
    public GameObject springCostDisplay;
    public GameObject springBuyBtn;

    public GameObject gearAmountDisplay;
    public GameObject gearCostDisplay;
    public GameObject gearBuyBtn;

    public GameObject leverAmountDisplay;
    public GameObject leverCostDisplay;
    public GameObject leverBuyBtn;

    public GameObject sprocketAmountDisplay;
    public GameObject sprocketCostDisplay;
    public GameObject sprocketBuyBtn;

    public GameObject widgetAmountDisplay;
    public GameObject widgetCostDisplay;
    public GameObject widgetBuyBtn;

    public GameObject gidgetAmountDisplay;
    public GameObject gidgetCostDisplay;
    public GameObject gidgetBuyBtn;

    public AudioSource itemBought;
    void Update()
    {
        updateSellButtons(rodAmountDisplay, rodCostDisplay, rod, rodCost, rodBuyBtn);
        updateSellButtons(plateAmountDisplay, plateCostDisplay, plate, plateCost, plateBuyBtn);
        updateSellButtons(springAmountDisplay, springCostDisplay, spring, springCost, springBuyBtn);
        updateSellButtons(gearAmountDisplay, gearCostDisplay, gear, gearCost, gearBuyBtn);
        updateSellButtons(leverAmountDisplay, leverCostDisplay, lever, leverCost, leverBuyBtn);
        updateSellButtons(sprocketAmountDisplay, sprocketCostDisplay, sprocket, sprocketCost, sprocketBuyBtn);
        updateSellButtons(widgetAmountDisplay, widgetCostDisplay, widget, widgetCost, widgetBuyBtn);
        updateSellButtons(gidgetAmountDisplay, gidgetCostDisplay, gidget, gidgetCost, gidgetBuyBtn);
    }

    public void buyRods()
    {
        itemBought.Play();
        GlobalData.rodCount += (rod * multiplier);
        GlobalData.shinyCount -= ((rodCost + ShopSell.material-1) * multiplier);
    }

    public void buyPlates()
    {
        itemBought.Play();
        GlobalData.plateCount += (plate * multiplier);
        GlobalData.shinyCount -= ((plateCost + ShopSell.material-1) * multiplier);
    }
    public void buySprings()
    {
        itemBought.Play();
        GlobalData.springCount += (spring * multiplier);
        GlobalData.shinyCount -= ((springCost + ShopSell.material-1) * multiplier);
    }
    public void buyGears()
    {
        itemBought.Play();
        GlobalData.gearCount += (gear * multiplier);
        GlobalData.shinyCount -= ((gearCost + ShopSell.material-1) * multiplier);
    }
    public void buyLevers()
    {
        itemBought.Play();
        GlobalData.leverCount += (lever * multiplier);
        GlobalData.shinyCount -= ((leverCost + ShopSell.material-1) * multiplier);
    }
    public void buySprockets()
    {
        itemBought.Play();
        GlobalData.sprocketCount += (sprocket * multiplier);
        GlobalData.shinyCount -= ((sprocketCost + ShopSell.material-1) * multiplier);
    }
    public void buyWidgets()
    {
        itemBought.Play();
        GlobalData.widgetCount += (widget * multiplier);
        GlobalData.shinyCount -= ((widgetCost + ShopSell.material-1) * multiplier);
    }
    public void buyGidgets()
    {
        itemBought.Play();
        GlobalData.gidgetCount += (gidget * multiplier);
        GlobalData.shinyCount -= ((gidgetCost + ShopSell.material-1) * multiplier);
    }

    public void updateSellButtons(GameObject amountDisplay, GameObject costDisplay, int item, int cost, GameObject button )
    {
        amountDisplay.GetComponent<Text>().text = (item * multiplier).ToString();
        costDisplay.GetComponent<Text>().text = ((cost + ShopSell.material-1) * multiplier).ToString();

        if (GlobalData.shinyCount < ((cost + ShopSell.material-1) * multiplier))
        {
            button.GetComponent<Button>().interactable = false;
        }
        else
            button.GetComponent<Button>().interactable = true;
    }
}

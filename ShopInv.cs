using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopInv : MonoBehaviour
{
    public GameObject rodDisplay;
    public GameObject plateDisplay;
    public GameObject springInv;
    public GameObject springDisplay;
    public GameObject gearInv;
    public GameObject gearDisplay;
    public GameObject leverInv;
    public GameObject leverDisplay;
    public GameObject sprocketInv;
    public GameObject sprocketDisplay;
    public GameObject widgetInv;
    public GameObject widgetDisplay;
    public GameObject gidgetInv;
    public GameObject gidgetDisplay;
    public GameObject doodadInv;
    public GameObject doodadDisplay;
    public GameObject whizbangInv;
    public GameObject whizbangDisplay;
    public GameObject whatzitInv;
    public GameObject whatzitDisplay;
    public GameObject thingamajigInv;
    public GameObject thingamajigDisplay;
    public GameObject gizmoInv;
    public GameObject gizmoDisplay;
    public GameObject gadgetInv;
    public GameObject gadgetDisplay;

    // Update is called once per frame
    void Update()
    {
        rodDisplay.GetComponent<Text>().text = GlobalData.rodCount.ToString();
        plateDisplay.GetComponent<Text>().text = GlobalData.plateCount.ToString();

        if (GlobalData.springCount < 0)
        {
            springInv.GetComponent<Image>().enabled = false;
            springDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {

            springInv.GetComponent<Image>().enabled = true;
            springDisplay.GetComponent<Text>().enabled = true;
            springDisplay.GetComponent<Text>().text = GlobalData.springCount.ToString();
        }

        if (GlobalData.gearCount < 0)
        {
            gearInv.GetComponent<Image>().enabled = false;
            gearDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            gearInv.GetComponent<Image>().enabled = true;
            gearDisplay.GetComponent<Text>().enabled = true;
            gearDisplay.GetComponent<Text>().text = GlobalData.gearCount.ToString();
        }
        if (GlobalData.leverCount < 0)
        {
            leverInv.GetComponent<Image>().enabled = false;
            leverDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            leverInv.GetComponent<Image>().enabled = true;
            leverDisplay.GetComponent<Text>().enabled = true;
            leverDisplay.GetComponent<Text>().text = GlobalData.leverCount.ToString();
        }
        if (GlobalData.sprocketCount < 0)
        {
            sprocketInv.GetComponent<Image>().enabled = false;
            sprocketDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            sprocketInv.GetComponent<Image>().enabled = true;
            sprocketDisplay.GetComponent<Text>().enabled = true;
            sprocketDisplay.GetComponent<Text>().text = GlobalData.sprocketCount.ToString();
        }
        if (GlobalData.widgetCount < 0)
        {
            widgetInv.GetComponent<Image>().enabled = false;
            widgetDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            widgetInv.GetComponent<Image>().enabled = true;
            widgetDisplay.GetComponent<Text>().enabled = true;
            widgetDisplay.GetComponent<Text>().text = GlobalData.widgetCount.ToString();
        }
        if (GlobalData.gidgetCount < 0)
        {
            gidgetInv.GetComponent<Image>().enabled = false;
            gidgetDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            gidgetInv.GetComponent<Image>().enabled = true;
            gidgetDisplay.GetComponent<Text>().enabled = true;
            gidgetDisplay.GetComponent<Text>().text = GlobalData.gidgetCount.ToString();
        }
        if (GlobalData.doodadCount < 0)
        {
            doodadInv.GetComponent<Image>().enabled = false;
            doodadDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            doodadInv.GetComponent<Image>().enabled = true;
            doodadDisplay.GetComponent<Text>().enabled = true;
            doodadDisplay.GetComponent<Text>().text = GlobalData.doodadCount.ToString();
        }
        if (GlobalData.whizbangCount < 0)
        {
            whizbangInv.GetComponent<Image>().enabled = false;
            whizbangDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            whizbangInv.GetComponent<Image>().enabled = true;
            whizbangDisplay.GetComponent<Text>().enabled = true;
            whizbangDisplay.GetComponent<Text>().text = GlobalData.whizbangCount.ToString();
        }
        if (GlobalData.whatzitCount < 0)
        {
            whatzitInv.GetComponent<Image>().enabled = false;
            whatzitDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            whatzitInv.GetComponent<Image>().enabled = true;
            whatzitDisplay.GetComponent<Text>().enabled = true;
            whatzitDisplay.GetComponent<Text>().text = GlobalData.whatzitCount.ToString();
        }
        if (GlobalData.thingamajigCount < 0)
        {
            thingamajigInv.GetComponent<Image>().enabled = false;
            thingamajigDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            thingamajigInv.GetComponent<Image>().enabled = true;
            thingamajigDisplay.GetComponent<Text>().enabled = true;
            thingamajigDisplay.GetComponent<Text>().text = GlobalData.thingamajigCount.ToString();
        }
        if (GlobalData.gizmoCount < 0)
        {
            gizmoInv.GetComponent<Image>().enabled = false;
            gizmoDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            gizmoInv.GetComponent<Image>().enabled = true;
            gizmoDisplay.GetComponent<Text>().enabled = true;
            gizmoDisplay.GetComponent<Text>().text = GlobalData.gizmoCount.ToString();
        }
        if (GlobalData.gadgetCount < 0)
        {
            gadgetInv.GetComponent<Image>().enabled = false;
            gadgetDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            gadgetInv.GetComponent<Image>().enabled = true;
            gadgetDisplay.GetComponent<Text>().enabled = true;
            gadgetDisplay.GetComponent<Text>().text = GlobalData.gadgetCount.ToString();
        }
    }

  

}

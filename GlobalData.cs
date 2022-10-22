using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalData : MonoBehaviour
{
    
    //items and inventory
    public static int playerLevel = 0;
    public static int shinyCount = 0;
    public static int rodCount = 25;
    public static int plateCount = 10;
    public static int springCount = -1;
    public static int gearCount = -1;
    public static int leverCount = -1;
    public static int sprocketCount = -1;
    public static int widgetCount = -1;
    public static int maxWidgetCount = 0; 
    public static int gidgetCount = -1;
    public static int maxGidgetCount = 0; 
    public static int doodadCount = -1;
    public static int maxDoodadCount = 0; 
    public static int whizbangCount = -1;
    public static int maxWhizbangCount = 0; 
    public static int whatzitCount = -1;
    public static int maxWhatzitCount = 0; 
    public static int thingamajigCount = -1;
    public static int maxThingamajigCount = 0; 
    public static int gizmoCount = -1;
    public static int maxGizmoCount = 0; 
    public static int gadgetCount = -1;
    public static int maxGadgetCount = 0; 
    public static int craftsTilRepair = 400;
    public GameObject shinyDisplay;
    public GameObject shinyDisplayShop;
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

    public GameObject BGM;

    

    //machines
    public static bool screncherIsOn = false;
    public static bool screncherIsBorked = false;
    public static int screncherCraftsSinceRepair = 0;
    public static int screncherLevel = 0;
    
    public static bool whomperIsOn = false;
    public static bool whomperIsBorked = false;
    public static int whomperCraftsSinceRepair = 0;
    public static int whomperLevel = 0;

    public static bool sprockonaterIsOn = false;
    public static bool sprockonaterIsBorked = false;
    public static int sprockonaterCraftsSinceRepair = 0;
    public static int sprockonaterLevel = 0;

    public static bool crankyIsOn = false;
    public static bool crankyIsBorked = false;
    public static int crankyCraftsSinceRepair = 0;
    public static int crankyLevel = 0;

    public static bool fidgitronIsOn = false;
    public static bool fidgitronIsBorked = false;
    public static int fidgitronCraftsSinceRepair = 0;
    public static int fidgitronLevel = 0;

    public static bool supertsxIsOn = false;
    public static bool supertsxIsBorked = false;
    public static int supertsxCraftsSinceRepair = 0;
    public static int supertsxLevel = 0;

    public static bool hypergulatorIsOn = false;
    public static bool hypergulatorIsBorked = false;
    public static int hypergulatorCraftsSinceRepair = 0;
    public static int hypergulatorLevel = 0;

    public static bool phasiomaticIsOn = false;
    public static bool phasiomaticIsBorked = false;
    public static int phasiomaticCraftsSinceRepair = 0;
    public static int phasiomaticLevel = 0;

    public static bool catatranslyticIsOn = false;
    public static bool catatranslyticIsBorked = false;
    public static int catatranslyticCraftsSinceRepair = 0;
    public static int catatranslyticLevel = 0;

    public static bool crosspneumaticclunkerIsOn = false;
    public static bool crosspneumaticclunkerIsBorked = false;
    public static int crosspneumaticclunkerCraftsSinceRepair = 0;
    public static int crosspneumaticclunkerLevel = 0;

    public static bool magnetoconverterIsOn = false;
    public static bool magnetoconverterIsBorked = false;
    public static int magnetoconverterCraftsSinceRepair = 0;
    public static int magnetoconverterLevel = 0;

    public static bool photooscilatorIsOn = false;
    public static bool photooscilatorIsBorked = false;
    public static int photooscilatorCraftsSinceRepair = 0;
    public static int photooscilatorLevel = 0;



    private void Start()
    {
        if (MenuManager.isLoading1)
        {
            MenuManager.LoadGame(1);
        }
        else if (MenuManager.isLoading2)
        {
            MenuManager.LoadGame(2);
        }
        else if (MenuManager.isLoading3)
        {
            MenuManager.LoadGame(3);
        }
        else if (MenuManager.isLoading4)
        {
            MenuManager.LoadGame(4);
        }
        else
        {
            
        }
    }

    void Update()
    {
        shinyDisplay.GetComponent<Text>().text = shinyCount.ToString();
        shinyDisplayShop.GetComponent<Text>().text = shinyCount.ToString();
        rodDisplay.GetComponent<Text>().text = rodCount.ToString();
        plateDisplay.GetComponent<Text>().text = plateCount.ToString();

        if (springCount < 0)
        {
            springInv.GetComponent<Image>().enabled = false;
            springDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {

            springInv.GetComponent<Image>().enabled = true;
            springDisplay.GetComponent<Text>().enabled = true;
            springDisplay.GetComponent<Text>().text = springCount.ToString();
        }

        if (gearCount < 0)
        {
            gearInv.GetComponent<Image>().enabled = false;
            gearDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            gearInv.GetComponent<Image>().enabled = true;
            gearDisplay.GetComponent<Text>().enabled = true;
            gearDisplay.GetComponent<Text>().text = gearCount.ToString();
        }
        if (leverCount < 0)
        {
            leverInv.GetComponent<Image>().enabled = false;
            leverDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            leverInv.GetComponent<Image>().enabled = true;
            leverDisplay.GetComponent<Text>().enabled = true;
            leverDisplay.GetComponent<Text>().text = leverCount.ToString();
        }
        if (sprocketCount < 0)
        {
            sprocketInv.GetComponent<Image>().enabled = false;
            sprocketDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            sprocketInv.GetComponent<Image>().enabled = true;
            sprocketDisplay.GetComponent<Text>().enabled = true;
            sprocketDisplay.GetComponent<Text>().text = sprocketCount.ToString();
        }
        if (widgetCount < 0)
        {
            widgetInv.GetComponent<Image>().enabled = false;
            widgetDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            widgetInv.GetComponent<Image>().enabled = true;
            widgetDisplay.GetComponent<Text>().enabled = true;
            widgetDisplay.GetComponent<Text>().text = widgetCount.ToString();
        }
        if (gidgetCount < 0)
        {
            gidgetInv.GetComponent<Image>().enabled = false;
            gidgetDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            gidgetInv.GetComponent<Image>().enabled = true;
            gidgetDisplay.GetComponent<Text>().enabled = true;
            gidgetDisplay.GetComponent<Text>().text = gidgetCount.ToString();
        }
        if (doodadCount < 0)
        {
            doodadInv.GetComponent<Image>().enabled = false;
            doodadDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            doodadInv.GetComponent<Image>().enabled = true;
            doodadDisplay.GetComponent<Text>().enabled = true;
            doodadDisplay.GetComponent<Text>().text = doodadCount.ToString();
        }
        if (whizbangCount < 0)
        {
            whizbangInv.GetComponent<Image>().enabled = false;
            whizbangDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            whizbangInv.GetComponent<Image>().enabled = true;
            whizbangDisplay.GetComponent<Text>().enabled = true;
            whizbangDisplay.GetComponent<Text>().text = whizbangCount.ToString();
        }
        if (whatzitCount < 0)
        {
            whatzitInv.GetComponent<Image>().enabled = false;
            whatzitDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            whatzitInv.GetComponent<Image>().enabled = true;
            whatzitDisplay.GetComponent<Text>().enabled = true;
            whatzitDisplay.GetComponent<Text>().text = whatzitCount.ToString();
        }
        if (thingamajigCount < 0)
        {
            thingamajigInv.GetComponent<Image>().enabled = false;
            thingamajigDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            thingamajigInv.GetComponent<Image>().enabled = true;
            thingamajigDisplay.GetComponent<Text>().enabled = true;
            thingamajigDisplay.GetComponent<Text>().text = thingamajigCount.ToString();
        }
        if (gizmoCount < 0)
        {
            gizmoInv.GetComponent<Image>().enabled = false;
            gizmoDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            gizmoInv.GetComponent<Image>().enabled = true;
            gizmoDisplay.GetComponent<Text>().enabled = true;
            gizmoDisplay.GetComponent<Text>().text = gizmoCount.ToString();
        }
        if (gadgetCount < 0)
        {
            gadgetInv.GetComponent<Image>().enabled = false;
            gadgetDisplay.GetComponent<Text>().enabled = false;
        }
        else
        {
            gadgetInv.GetComponent<Image>().enabled = true;
            gadgetDisplay.GetComponent<Text>().enabled = true;
            gadgetDisplay.GetComponent<Text>().text = gadgetCount.ToString();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            BGM.SetActive(false);
        }

    }

  

}

using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class craftItem : MonoBehaviour
{
    public string item1;
    public string item2;
    public string item3;
    public string item4;

    public int indexOfRecipe;
    public bool craftFound = false;

    public AudioSource playSound;
    public AudioSource playError;


    public string[,] recipes = new string[,] { 
        { "rod", "rod", "none", "spring" }, 
        { "rod", "plate", "none", "gear" },
        { "rod", "gear", "none", "lever" },
        { "spring", "gear", "none", "sprocket"},
        { "sprocket", "sprocket", "lever", "widget" },
        { "sprocket", "lever", "widget", "gidget" },
        { "sprocket", "widget", "gidget", "doodad" },
        { "plate", "gidget", "doodad", "whizbang" },
        { "gidget", "whizbang", "whizbang", "whatzit" },
        { "widget", "doodad", "whatzit", "thingamajig" },
        { "gidget", "whizbang", "thingamajig", "gizmo" },
        { "whatzit", "thingamajig", "gizmo", "gadget" }
    };

    
    public GameObject warningPanel;
    public GameObject warningMessage;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            craft();
            
            if (!MachineManager.stayputerBuilt)
            {
                InventoryClick.ClearIt.clearCraft();
            }
        }
    }

    public void craft()
    {

        item1 = GlobalCraftingSlot.inSlot1;
        item2 = GlobalCraftingSlot.inSlot2;
        item3 = GlobalCraftingSlot.inSlot3;

        for (int i = 0; i < recipes.GetLength(0); i++)
        {
            if(recipes[i,0].Equals(item1) & recipes[i,1].Equals(item2) & recipes[i, 2].Equals(item3))
            {
                craftFound = true;
                item4 = recipes[i, 3];
                if(item1.Equals(item2) & item2.Equals(item3))
                {
                    if (checkMats(item1, 3))
                    {
                        playSound.Play();
                        subtractMats(item1, 3);
                        addMats(item4, 1);

                    }
                    else
                    {
                        playError.Play();
                        ShowWarning("Not Enough Mats");
                    }
                }
                else if (item1.Equals(item2))
                {
                    if(checkMats(item1,2) & checkMats(item3, 1))
                    {
                        playSound.Play();
                        subtractMats(item1, 2);
                        subtractMats(item3, 1);
                        addMats(item4, 1);
                    }
                    else
                    {
                        playError.Play();
                        ShowWarning("Not Enough Mats");
                    }
                }
                else if (item2.Equals(item3))
                {
                    if(checkMats(item2,2) & checkMats(item1, 1))
                    {
                        playSound.Play();
                        subtractMats(item2, 2);
                        subtractMats(item1, 1);
                        addMats(item4, 1);
                    }
                    else
                    {
                        playError.Play();
                        ShowWarning("Not Enough Mats");
                    }
                }
                else if (item1.Equals(item3))
                {
                    if(checkMats(item1,2) & checkMats(item2, 1))
                    {
                        playSound.Play();
                        subtractMats(item1, 2);
                        subtractMats(item2, 1);
                        addMats(item4, 1);
                    }
                    else
                    {
                        playError.Play();
                        ShowWarning("Not Enough Mats");
                    }
                }
                else
                {
                    if(checkMats(item1, 1) & checkMats(item2,1) & checkMats(item3, 1))
                    {
                        playSound.Play();
                        subtractMats(item1, 1);
                        subtractMats(item2, 1);
                        subtractMats(item3, 1);
                        addMats(item4, 1);

                    }
                    else
                    {
                        playError.Play();
                        ShowWarning("Not Enough Mats");
                    }
                        
                }                
            }
        }

        if (craftFound)
        {
            craftFound = false;
        }
        else
        {
            playError.Play();
            ShowWarning("INVALID RECIPE");
        }
            

        if (!MachineManager.stayputerBuilt)
        {
            InventoryClick.ClearIt.clearCraft();
        }
    }

    public static bool checkMats(string mat, int a)
    {
        switch (mat)
        {
            case "rod":
                return GlobalData.rodCount >= a;
            case "plate":
                return GlobalData.plateCount >= a;
            case "spring":
                return GlobalData.springCount >= a;
            case "gear":
                return GlobalData.gearCount >= a;
            case "lever":
                return GlobalData.leverCount >= a;
            case "sprocket":
                return GlobalData.sprocketCount >= a;
            case "widget":
                return GlobalData.widgetCount >= a;
            case "gidget":
                return GlobalData.gidgetCount >= a;
            case "doodad":
                return GlobalData.doodadCount >= a;
            case "whizbang":
                return GlobalData.whizbangCount >= a;
            case "whatzit":
                return GlobalData.whatzitCount >= a;
            case "thingamajig":
                return GlobalData.thingamajigCount >= a;
            case "gizmo":
                return GlobalData.gizmoCount >= a;
            case "gadget":
                return GlobalData.gadgetCount >= a;
            default:
                return true;
        }
    }
    
    
    public static void subtractMats(string mat, int a)
    {
        switch (mat)
        {
            case "rod":
                GlobalData.rodCount -= a;
                break;
            case "plate":
                GlobalData.plateCount -= a;
                break;
            case "spring":
                GlobalData.springCount -= a;
                break;
            case "gear":
                GlobalData.gearCount -= a;
                break;
            case "lever":
                GlobalData.leverCount -= a;
                break;
            case "sprocket":
                GlobalData.sprocketCount -= a;
                break;
            case "widget":
                GlobalData.widgetCount -= a;
                break;
            case "gidget":
                GlobalData.gidgetCount -= a;
                break;
            case "doodad":
                GlobalData.doodadCount -= a;
                break;
            case "whizbang":
                GlobalData.whizbangCount -= a;
                break;
            case "whatzit":
                GlobalData.whatzitCount -= a;
                break;
            case "thingamajig":
                GlobalData.thingamajigCount -= a;
                break;
            case "gizmo":
                GlobalData.gizmoCount -= a;
                break;
            case "gadget":
                GlobalData.gadgetCount -= a;
                break;
            default:
                break;
        }
    }

    public static void addMats(string mat, int a)
    {
        switch (mat)
        {
            case "rod":
                GlobalData.rodCount += a;
                break;
            case "plate":
                GlobalData.plateCount += a;
                break;
            case "spring":
                if (GlobalData.springCount < 0) GlobalData.springCount = 0;
                GlobalData.springCount += a;
                break;
            case "gear":
                if (GlobalData.gearCount < 0) GlobalData.gearCount = 0;
                GlobalData.gearCount += a;
                break;
            case "lever":
                if (GlobalData.leverCount < 0) GlobalData.leverCount = 0;
                GlobalData.leverCount += a;
                break;
            case "sprocket":
                if (GlobalData.sprocketCount < 0) GlobalData.sprocketCount = 0;
                GlobalData.sprocketCount += a;
                break;
            case "widget":
                if (GlobalData.widgetCount < 0) GlobalData.widgetCount = 0;
                GlobalData.widgetCount += a;
                GlobalData.maxWidgetCount += a;
                break;
            case "gidget":
                if (GlobalData.gidgetCount < 0) GlobalData.gidgetCount = 0;
                GlobalData.gidgetCount += a;
                GlobalData.maxGidgetCount += a;
                break;
            case "doodad":
                if (GlobalData.doodadCount < 0) GlobalData.doodadCount = 0;
                GlobalData.doodadCount += a;
                GlobalData.maxDoodadCount += a;
                break;
            case "whizbang":
                if (GlobalData.whizbangCount < 0) GlobalData.whizbangCount = 0;
                GlobalData.whizbangCount += a;
                GlobalData.maxWhizbangCount += a;
                break;
            case "whatzit":
                if (GlobalData.whatzitCount < 0) GlobalData.whatzitCount = 0;
                GlobalData.whatzitCount += a;
                GlobalData.maxWhatzitCount += a;
                break;
            case "thingamajig":
                if (GlobalData.thingamajigCount < 0) GlobalData.thingamajigCount = 0;
                GlobalData.thingamajigCount += a;
                GlobalData.maxThingamajigCount += a;
                break;
            case "gizmo":
                if (GlobalData.gizmoCount < 0) GlobalData.gizmoCount = 0;
                GlobalData.gizmoCount += a;
                GlobalData.maxGizmoCount += a;
                break;
            case "gadget":
                if (GlobalData.gadgetCount < 0) GlobalData.gadgetCount = 0;
                GlobalData.gadgetCount += a;
                GlobalData.maxGadgetCount += a;
                break;
            default:
                break;
        }
    }

    

    public void ShowWarning(string message)
    {
        warningPanel.GetComponent<Image>().enabled = true;
        warningMessage.GetComponent<Text>().text = message;
        warningPanel.GetComponent<Animation>().Play("Warning");
        
    }
}

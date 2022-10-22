using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magneto : MonoBehaviour
{
    public static int[] partCosts = {36,20,4,2};
    public static string[] partItems = { "plate", "gear", "doodad", "gizmo" };
    public static int repairStrength;
    public int sinceRepairs;
    public int tilRepairs;
    public int level;
    public int extra = 0;

    public bool machineOn = false;

    public AudioSource repairNeeded;

    public Sprite machineIcon;
    public GameObject legendPanel;
    public GameObject machineImage;
    public GameObject machineName;
    public GameObject machineLevel;
    public GameObject machineConsume;
    public GameObject machineProduce;

    void Start()
    {
        tilRepairs = GlobalData.craftsTilRepair;
    }

    // Update is called once per frame
    void Update()
    {
        sinceRepairs = GlobalData.magnetoconverterCraftsSinceRepair;
        level = GlobalData.magnetoconverterLevel;
        if (!machineOn)
        {
            machineOn = true;
            StartCoroutine(operateMachine());
        }

        if (MachineManager.magnetoconverterBuilt)
        {
            legendPanel.SetActive(true);
        }
        else
            legendPanel.SetActive(false);
        updateLegend();

    }

    IEnumerator operateMachine()
    {
        
        if (GlobalData.magnetoconverterIsOn)
        {
            craft();
            checkForRepairs();
        }
            
        yield return new WaitForSeconds(1);
        machineOn = false;
    }

    void checkForRepairs()
    {
        int chanceCheck = Mathf.FloorToInt((sinceRepairs - tilRepairs) / 6);
        if(sinceRepairs >= tilRepairs & (sinceRepairs - tilRepairs) % 6 == 0)
        {
            int borkChance = Random.Range(1, 101);
            if(borkChance < chanceCheck)
            {
                repairNeeded.Play();
                if (chanceCheck < 10)
                {
                    repairStrength = 1;
                }
                else if (chanceCheck > 20)
                {
                    repairStrength = 3;
                }
                else
                    repairStrength = 2;

                GlobalData.magnetoconverterIsBorked = true;
                GlobalData.magnetoconverterIsOn = false;
            }
            
        }
    }

    void craft()
    {
        if (GlobalData.magnetoconverterIsOn & craftItem.checkMats("gidget", level) & craftItem.checkMats("whizbang", level) & craftItem.checkMats("thingamajig", level))
        {
            if (GlobalData.magnetoconverterLevel == 4)
            {
                extra = 1;
            }

            if (GlobalData.magnetoconverterLevel == 5)
            {
                extra = 2;
            }

            GlobalData.magnetoconverterCraftsSinceRepair += 1;
            craftItem.subtractMats("gidget", level);
            craftItem.subtractMats("whizbang", level);
            craftItem.subtractMats("thingamajig", level);
            craftItem.addMats("gizmo", level + extra);
        }
    }

    public void updateLegend()
    {
        machineImage.GetComponent<Image>().sprite = machineIcon;
        machineName.GetComponent<Text>().text = "Magneto";
        machineLevel.GetComponent<Text>().text = level.ToString();
        machineConsume.GetComponent<Text>().text = level + " Parts per sec";
        machineProduce.GetComponent<Text>().text = (level + extra) + " Gizmos per sec";
    }


}

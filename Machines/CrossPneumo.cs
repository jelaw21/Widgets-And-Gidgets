using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrossPneumo : MonoBehaviour
{
    public static int[] partCosts = {22,16,8,2};
    public static string[] partItems = { "spring", "sprocket", "gidget", "thingamajig" };
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
        sinceRepairs = GlobalData.crosspneumaticclunkerCraftsSinceRepair;
        level = GlobalData.crosspneumaticclunkerLevel;
        if (!machineOn)
        {
            machineOn = true;
            StartCoroutine(operateMachine());
        }
        if (MachineManager.crosspneumaticclunkerBuilt)
        {
            legendPanel.SetActive(true);
        }
        else
            legendPanel.SetActive(false);
        updateLegend();

    }

    IEnumerator operateMachine()
    {
        
        if (GlobalData.crosspneumaticclunkerIsOn)
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

                GlobalData.crosspneumaticclunkerIsBorked = true;
                GlobalData.crosspneumaticclunkerIsOn = false;
            }

            
        }
    }

    void craft()
    {
        
        if (GlobalData.crosspneumaticclunkerIsOn & craftItem.checkMats("widget", level) & craftItem.checkMats("doodad", level) & craftItem.checkMats("whatzit", level))
        {
            if (GlobalData.crosspneumaticclunkerLevel == 4)
            {
                extra = 1;
            }

            if (GlobalData.crosspneumaticclunkerLevel == 5)
            {
                extra = 2;
            }

            GlobalData.crosspneumaticclunkerCraftsSinceRepair += 1;
            craftItem.subtractMats("widget", level);
            craftItem.subtractMats("doodad", level);
            craftItem.subtractMats("whatzit", level);
            craftItem.addMats("thingamajig", level + extra);
        }
    }

    public void updateLegend()
    {
        machineImage.GetComponent<Image>().sprite = machineIcon;
        machineName.GetComponent<Text>().text = "Catatranslytic";
        machineLevel.GetComponent<Text>().text = level.ToString();
        machineConsume.GetComponent<Text>().text = level + " Parts per sec";
        machineProduce.GetComponent<Text>().text = (level + extra) + " Thingamajigs per sec";
    }


}

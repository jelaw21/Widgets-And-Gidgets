using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hypergulator : MonoBehaviour
{
    public static int[] partCosts = {20, 10, 4, 2};
    public static string[] partItems = { "plate", "sprocket", "widget", "doodad" };
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
        sinceRepairs = GlobalData.hypergulatorCraftsSinceRepair;
        level = GlobalData.hypergulatorLevel;
        if (!machineOn)
        {
            machineOn = true;
            StartCoroutine(operateMachine());
        }

        if (MachineManager.hypergulatorBuilt)
        {
            legendPanel.SetActive(true);
        }
        else
            legendPanel.SetActive(false);
        updateLegend();

    }

    IEnumerator operateMachine()
    {
        
        if (GlobalData.hypergulatorIsOn)
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

                GlobalData.hypergulatorIsBorked = true;
                GlobalData.hypergulatorIsOn = false;
            }
            
        }
    }

    void craft()
    {
        
        if (GlobalData.hypergulatorIsOn & craftItem.checkMats("widget", level) & craftItem.checkMats("gidget", level) & craftItem.checkMats("sprocket", level))
        {
            if (GlobalData.hypergulatorLevel == 4)
            {
                extra = 1;
            }

            if (GlobalData.hypergulatorLevel == 5)
            {
                extra = 2;
            }

            GlobalData.hypergulatorCraftsSinceRepair += 1;
            craftItem.subtractMats("widget", level);
            craftItem.subtractMats("gidget", level);
            craftItem.subtractMats("sprocket", level);
            craftItem.addMats("doodad", level + extra);
        }
    }

    public void updateLegend()
    {
        machineImage.GetComponent<Image>().sprite = machineIcon;
        machineName.GetComponent<Text>().text = "Hypergulator";
        machineLevel.GetComponent<Text>().text = level.ToString();
        machineConsume.GetComponent<Text>().text = level + " Parts per sec";
        machineProduce.GetComponent<Text>().text = (level + extra) + " Doodads per sec";
    }


}

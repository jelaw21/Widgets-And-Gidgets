using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cranky : MonoBehaviour
{
    public static int[] partCosts = {10, 8, 6, 4 };
    public static string[] partItems = { "plate", "gear", "sprocket", "lever" };
    public static int repairStrength = 0;
    public int sinceRepairs;
    public int tilRepairs;
    public int level;
    int extra = 0;

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
        sinceRepairs = GlobalData.crankyCraftsSinceRepair;
        level = GlobalData.crankyLevel;
        if (!machineOn)
        {
            machineOn = true;
            StartCoroutine(operateMachine());
        }

        if (MachineManager.crankyBuilt)
        {
            legendPanel.SetActive(true);
        }
        else
            legendPanel.SetActive(false);
        updateLegend();

    }

    IEnumerator operateMachine()
    {
        
        if (GlobalData.crankyIsOn)
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

                GlobalData.crankyIsBorked = true;
                GlobalData.crankyIsOn = false;
            }
        }
    }

    void craft()
    {
        
        if (GlobalData.crankyIsOn & craftItem.checkMats("rod", level) & craftItem.checkMats("gear", level))
        {
            if (GlobalData.crankyLevel == 4)
            {
                extra = 1;
            }

            if (GlobalData.crankyLevel == 5)
            {
                extra = 2;
            }
;
            GlobalData.crankyCraftsSinceRepair += 1;
            craftItem.subtractMats("rod", level);
            craftItem.subtractMats("gear", level);
            craftItem.addMats("lever", level+extra);
        }
    }

    public void updateLegend()
    {
        machineImage.GetComponent<Image>().sprite = machineIcon;
        machineName.GetComponent<Text>().text = "Cranky";
        machineLevel.GetComponent<Text>().text = level.ToString();
        machineConsume.GetComponent<Text>().text = level + " Parts per sec";
        machineProduce.GetComponent<Text>().text = (level + extra) + " Levers per sec";
    }


}

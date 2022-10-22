using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sprockonater : MonoBehaviour
{
    public static int[] partCosts = {12,8,4,4 };
    public static string[] partItems = { "rod", "spring", "gear", "sprocket" };
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
        sinceRepairs = GlobalData.sprockonaterCraftsSinceRepair;
        level = GlobalData.sprockonaterLevel;
        if (!machineOn)
        {
            machineOn = true;
            StartCoroutine(operateMachine());
        }

        if (MachineManager.sprockonaterBuilt)
        {
            legendPanel.SetActive(true);
        }
        else
            legendPanel.SetActive(false);

        updateLegend();

    }

    IEnumerator operateMachine()
    {
        
        if (GlobalData.sprockonaterIsOn)
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

                GlobalData.sprockonaterIsBorked = true;
                GlobalData.sprockonaterIsOn = false;
            }            
        }
    }

    void craft()
    {
        
        if (GlobalData.sprockonaterIsOn & craftItem.checkMats("gear", level) & craftItem.checkMats("spring", level))
        {
            if (level == 4)
            {
                extra = 1;
            }

            if (level == 5)
            {
                extra = 2;
            }

            GlobalData.sprockonaterCraftsSinceRepair += 1;
            craftItem.subtractMats("gear", level);
            craftItem.subtractMats("spring", level);
            craftItem.addMats("sprocket", level+extra);
        }
    }

    public void updateLegend()
    {
        machineImage.GetComponent<Image>().sprite = machineIcon;
        machineName.GetComponent<Text>().text = "Sprockonater";
        machineLevel.GetComponent<Text>().text = level.ToString();
        machineConsume.GetComponent<Text>().text = level + " Parts per sec";
        machineProduce.GetComponent<Text>().text = (level + extra) + " Sprockets per sec";
    }


}

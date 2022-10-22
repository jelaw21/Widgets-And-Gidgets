using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Whomper : MonoBehaviour
{
    public static int[] partCosts = {4,6,8,3 };
    public static string[] partItems = { "plate", "spring", "gear", "sprocket" };
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
        sinceRepairs = GlobalData.whomperCraftsSinceRepair;
        level = GlobalData.whomperLevel;
        if (!machineOn)
        {
            machineOn = true;
            StartCoroutine(operateMachine());
        }

        if (MachineManager.whomperBuilt)
        {
            legendPanel.SetActive(true);
        }
        else
            legendPanel.SetActive(false);
        updateLegend();

    }

    IEnumerator operateMachine()
    {
        
        if (GlobalData.whomperIsOn)
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

                GlobalData.whomperIsBorked = true;
                GlobalData.whomperIsOn = false;
            }
            
        }
    }

    void craft()
    {
        
        if (GlobalData.whomperIsOn & craftItem.checkMats("rod", level) & craftItem.checkMats("plate", level))
        {
            if (level == 4)
            {
                extra = 1;
            }

            if (level == 5)
            {
                extra = 2;
            }

            GlobalData.whomperCraftsSinceRepair += 1;
            craftItem.subtractMats("rod", level);
            craftItem.subtractMats("plate", level);
            craftItem.addMats("gear", level + extra);
        }
    }

    public void updateLegend()
    {
        machineImage.GetComponent<Image>().sprite = machineIcon;
        machineName.GetComponent<Text>().text = "Whomper";
        machineLevel.GetComponent<Text>().text = level.ToString();
        machineConsume.GetComponent<Text>().text = level + " Parts per sec";
        machineProduce.GetComponent<Text>().text = (level + extra) + " Gears per sec";
    }


}

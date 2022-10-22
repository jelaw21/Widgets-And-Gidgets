using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screncher : MonoBehaviour
{
    public static int[] partCosts = {10, 6, 4, 6 };
    public static string[] partItems = { "rod", "plate", "spring", "gear" };
    public static int repairStrength = 0;
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
        sinceRepairs = GlobalData.screncherCraftsSinceRepair;
        level = GlobalData.screncherLevel;
        if (!machineOn)
        {
            machineOn = true;
            StartCoroutine(operateMachine());
        }

        if (MachineManager.screncherBuilt)
        {
            legendPanel.SetActive(true);
        }
        else
            legendPanel.SetActive(false);

        updateLegend();

    }

    IEnumerator operateMachine()
    {
        
        if (GlobalData.screncherIsOn)
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
        if(sinceRepairs >= tilRepairs & (sinceRepairs-tilRepairs)%6 == 0)
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

                GlobalData.screncherIsBorked = true;
                GlobalData.screncherIsOn = false;
            }
            
        }
    }

    void craft()
    {
               
        if (GlobalData.screncherIsOn & craftItem.checkMats("rod", level * 2))
        {
            if (level == 4)
            {
                extra = 1;
            }

            if (level == 5)
            {
                extra = 2;
            }

            GlobalData.screncherCraftsSinceRepair += 1;
            craftItem.subtractMats("rod", level * 2);
            craftItem.addMats("spring", level + extra);
        }
    }

    public void updateLegend()
    {
        machineImage.GetComponent<Image>().sprite = machineIcon;
        machineName.GetComponent<Text>().text = "Screncher";
        machineLevel.GetComponent<Text>().text = level.ToString();
        machineConsume.GetComponent<Text>().text = level + " Parts per sec";
        machineProduce.GetComponent<Text>().text = (level + extra) + " Springs per sec";
    }


}

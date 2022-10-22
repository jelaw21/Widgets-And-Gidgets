using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fidgitron : MonoBehaviour
{
    public static int[] partCosts = {12,8,6,4};
    public static string[] partItems = { "plate", "sprocket", "lever", "widget" };
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
        sinceRepairs = GlobalData.fidgitronCraftsSinceRepair;
        level = GlobalData.fidgitronLevel;
        if (!machineOn)
        {
            machineOn = true;
            StartCoroutine(operateMachine());
        }
        
        if (MachineManager.fidgitronBuilt)
        {
            legendPanel.SetActive(true);
        }
        else
            legendPanel.SetActive(false);

        updateLegend();

    }

    IEnumerator operateMachine()
    {
        
        if (GlobalData.fidgitronIsOn)
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

                GlobalData.fidgitronIsBorked = true;
                GlobalData.fidgitronIsOn = false;
            }

            
        }
    }

    void craft()
    {
        if (GlobalData.fidgitronIsOn & craftItem.checkMats("sprocket", GlobalData.fidgitronLevel * 2) & craftItem.checkMats("lever", GlobalData.fidgitronLevel))
        {
            if (level == 4)
            {
                extra = 1;
            }

            if (GlobalData.fidgitronLevel == 5)
            {
                extra = 2;
            }

            GlobalData.fidgitronCraftsSinceRepair += 1;
            craftItem.subtractMats("sprocket", level * 2);
            craftItem.subtractMats("lever", level);
            craftItem.addMats("widget", level + extra);
        }
    }

    public void updateLegend()
    {
        machineImage.GetComponent<Image>().sprite = machineIcon;
        machineName.GetComponent<Text>().text = "Fidgitron";
        machineLevel.GetComponent<Text>().text = level.ToString();
        machineConsume.GetComponent<Text>().text = level + " Parts per sec";
        machineProduce.GetComponent<Text>().text = (level + extra) + " Widget per sec";
    }

}

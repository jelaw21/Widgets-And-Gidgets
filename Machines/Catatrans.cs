using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Catatrans : MonoBehaviour
{
    public static int[] partCosts = {30,16,6,4};
    public static string[] partItems = { "plate", "spring", "gidget", "whatzit" };
    public static int repairStrength;
    public int sinceRepairs;
    public int tilRepairs;
    public int level;
    public int extra = 0;

    public bool machineOn = false;

    public AudioSource repairSound;

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
        sinceRepairs = GlobalData.catatranslyticCraftsSinceRepair;
        level = GlobalData.catatranslyticLevel;
        if (!machineOn)
        {
            machineOn = true;
            StartCoroutine(operateMachine());
        }
        
        if (MachineManager.catatranslyticBuilt)
        {
            legendPanel.SetActive(true);
        }
        else
            legendPanel.SetActive(false);
        updateLegend();
        
    }

    IEnumerator operateMachine()
    {
        
        if (GlobalData.catatranslyticIsOn)
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
                repairSound.Play();
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
                GlobalData.catatranslyticIsBorked = true;
                GlobalData.catatranslyticIsOn = false;
            }

            
        }

    }

    void craft()
    {
        if (GlobalData.catatranslyticIsOn & craftItem.checkMats("whizbang", level * 2) & craftItem.checkMats("gidget", level))
        {
            if (GlobalData.catatranslyticLevel == 4)
            {
                extra = 1;
            }

            if (GlobalData.catatranslyticLevel == 5)
            {
                extra = 2;
            }

            
            GlobalData.catatranslyticCraftsSinceRepair += 1;
            craftItem.subtractMats("whizbang", level * 2);
            craftItem.subtractMats("gidget", level);
            craftItem.addMats("whatzit", level+extra);
        }
    }

    public void updateLegend()
    {
        machineImage.GetComponent<Image>().sprite = machineIcon;
        machineName.GetComponent<Text>().text = "Catatranslytic";
        machineLevel.GetComponent<Text>().text = level.ToString();
        machineConsume.GetComponent<Text>().text = level + " Parts per sec";
        machineProduce.GetComponent<Text>().text = (level + extra) + " Whatzits per sec";
    }


}

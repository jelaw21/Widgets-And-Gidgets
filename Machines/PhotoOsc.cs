using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoOsc : MonoBehaviour
{
    public static int[] partCosts = {30,6,6,2};
    public static string[] partItems = { "spring", "widget", "whatzit", "gadget" };
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
        sinceRepairs = GlobalData.photooscilatorCraftsSinceRepair;
        level = GlobalData.photooscilatorLevel;
        if (!machineOn)
        {
            machineOn = true;
            StartCoroutine(operateMachine());
        }

        if (MachineManager.photooscilatorBuilt)
        {
            legendPanel.SetActive(true);
        }
        else
            legendPanel.SetActive(false);

        updateLegend();

    }

    IEnumerator operateMachine()
    {
        
        if (GlobalData.photooscilatorIsOn)
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

                GlobalData.photooscilatorIsBorked = true;
                GlobalData.photooscilatorIsOn = false;
            }
            
        }
    }

    void craft()
    {
        
        if (GlobalData.photooscilatorIsOn & craftItem.checkMats("whatzit", level) & craftItem.checkMats("thingamajig", level) & craftItem.checkMats("gizmo", level))
        {
            if (level == 4)
            {
                extra = 1;
            }

            if (level == 5)
            {
                extra = 2;
            }

            GlobalData.photooscilatorCraftsSinceRepair += 1;
            craftItem.subtractMats("whatzit", level);
            craftItem.subtractMats("thingamajig", level);
            craftItem.subtractMats("gizmo", level + extra);
            craftItem.addMats("gadget", level + extra);

        }
    }

    public void updateLegend()
    {
        machineImage.GetComponent<Image>().sprite = machineIcon;
        machineName.GetComponent<Text>().text = "Photo Oscilator";
        machineLevel.GetComponent<Text>().text = level.ToString();
        machineConsume.GetComponent<Text>().text = level + " Parts per sec";
        machineProduce.GetComponent<Text>().text = (level + extra) + " Gadgets per sec";
    }


}

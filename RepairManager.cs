using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RepairManager : MonoBehaviour
{

    public static string activeRepair = "none";

    public GameObject blueprintButton;
    public GameObject machineImage;
    public GameObject partOneText;
    public GameObject partOneImage;
    public GameObject partTwoText;
    public GameObject partTwoImage;
    public GameObject partThreeText;
    public GameObject partThreeImage;
    public GameObject partFourText;
    public GameObject partFourImage;

    //Machine Icons
    public Sprite stayputerIcon;
    public Sprite screncherIcon;
    public Sprite whomperIcon;
    public Sprite sprockonaterIcon;
    public Sprite crankyIcon;
    public Sprite fidgitronIcon;
    public Sprite supertsxIcon;
    public Sprite hypergulatorIcon;
    public Sprite phasiomaticIcon;
    public Sprite catatranslyticIcon;
    public Sprite crosspneumaticclunkerIcon;
    public Sprite magnetoconverterIcon;
    public Sprite photooscilatorIcon;

    public AudioSource repairSound;

    // Update is called once per frame
    void Update()
    {

        if (GlobalData.screncherIsBorked)
        {
            activeRepair = "screncher";
        }
        else if (GlobalData.whomperIsBorked)
        {
            activeRepair = "whomper";
        }
        else if (GlobalData.sprockonaterIsBorked)
        {
            activeRepair = "sprockonater";
        }
        else if (GlobalData.crankyIsBorked)
        {
            activeRepair = "cranky";
        }
        else if (GlobalData.fidgitronIsBorked)
        {
            activeRepair = "fidgitron";
        }
        else if (GlobalData.supertsxIsBorked)
        {
            activeRepair = "supertsx";
        }
        else if (GlobalData.hypergulatorIsBorked)
        {
            activeRepair = "hypergulator";
        }
        else if (GlobalData.phasiomaticIsBorked)
        {
            activeRepair = "phasiomatic";
        }
        else if (GlobalData.catatranslyticIsBorked)
        {
            activeRepair = "catatrans";
        }
        else if (GlobalData.crosspneumaticclunkerIsBorked)
        {
            activeRepair = "crosspneumo";
        }
        else if (GlobalData.magnetoconverterIsBorked)
        {
            activeRepair = "magneto";
        }
        else if (GlobalData.photooscilatorIsBorked)
        {
            activeRepair = "photo";
        }
        else
        {
            activeRepair = "none";
        }

        switch (activeRepair)
        {
            case "screncher":
                updateButton(screncherIcon, GlobalData.screncherLevel, Screncher.partCosts[0], Parts.part.lookup(Screncher.partItems[0]), Screncher.partCosts[1], Parts.part.lookup(Screncher.partItems[1]), Screncher.partCosts[2], Parts.part.lookup(Screncher.partItems[2]), Screncher.partCosts[3], Parts.part.lookup(Screncher.partItems[3]), Screncher.repairStrength);
                if (checkMats("screncher")) 
                    blueprintButton.GetComponent<Button>().interactable = true;
                else
                    blueprintButton.GetComponent<Button>().interactable = false;
                break;
            case "whomper":
                updateButton(whomperIcon, GlobalData.whomperLevel, Whomper.partCosts[0], Parts.part.lookup(Whomper.partItems[0]), Whomper.partCosts[1], Parts.part.lookup(Whomper.partItems[1]), Whomper.partCosts[2], Parts.part.lookup(Whomper.partItems[2]), Whomper.partCosts[3], Parts.part.lookup(Whomper.partItems[3]), Whomper.repairStrength);
                if (checkMats("whomper"))
                    blueprintButton.GetComponent<Button>().interactable = true;
                else
                    blueprintButton.GetComponent<Button>().interactable = false;
                break;
            case "sprockonater":
                updateButton(sprockonaterIcon, GlobalData.sprockonaterLevel, Sprockonater.partCosts[0], Parts.part.lookup(Sprockonater.partItems[0]), Sprockonater.partCosts[1], Parts.part.lookup(Sprockonater.partItems[1]), Sprockonater.partCosts[2], Parts.part.lookup(Sprockonater.partItems[2]), Sprockonater.partCosts[3], Parts.part.lookup(Sprockonater.partItems[3]), Sprockonater.repairStrength);
                if (checkMats("sprockonater"))
                    blueprintButton.GetComponent<Button>().interactable = true;
                else
                    blueprintButton.GetComponent<Button>().interactable = false; 
                break;
            case "cranky":
                updateButton(crankyIcon, GlobalData.crankyLevel, Cranky.partCosts[0], Parts.part.lookup(Cranky.partItems[0]), Cranky.partCosts[1], Parts.part.lookup(Cranky.partItems[1]), Cranky.partCosts[2], Parts.part.lookup(Cranky.partItems[2]), Cranky.partCosts[3], Parts.part.lookup(Cranky.partItems[3]), Cranky.repairStrength);
                if (checkMats("cranky"))
                    blueprintButton.GetComponent<Button>().interactable = true;
                else
                    blueprintButton.GetComponent<Button>().interactable = false;
                break;
            case "fidgitron":
                updateButton(fidgitronIcon, GlobalData.fidgitronLevel, Fidgitron.partCosts[0], Parts.part.lookup(Fidgitron.partItems[0]), Fidgitron.partCosts[1], Parts.part.lookup(Fidgitron.partItems[1]), Fidgitron.partCosts[2], Parts.part.lookup(Fidgitron.partItems[2]), Fidgitron.partCosts[3], Parts.part.lookup(Fidgitron.partItems[3]), Fidgitron.repairStrength);
                if (checkMats("fidgitron"))
                    blueprintButton.GetComponent<Button>().interactable = true;
                else
                    blueprintButton.GetComponent<Button>().interactable = false;
                break;
            case "supertsx":
                updateButton(supertsxIcon, GlobalData.supertsxLevel, SuperTSX.partCosts[0], Parts.part.lookup(SuperTSX.partItems[0]), SuperTSX.partCosts[1], Parts.part.lookup(SuperTSX.partItems[1]), SuperTSX.partCosts[2], Parts.part.lookup(SuperTSX.partItems[2]), SuperTSX.partCosts[3], Parts.part.lookup(SuperTSX.partItems[3]), SuperTSX.repairStrength);
                if (checkMats("supertsx"))
                    blueprintButton.GetComponent<Button>().interactable = true;
                else
                    blueprintButton.GetComponent<Button>().interactable = false;
                break;
            case "hypergulator":
                updateButton(hypergulatorIcon, GlobalData.hypergulatorLevel, Hypergulator.partCosts[0], Parts.part.lookup(Hypergulator.partItems[0]), Hypergulator.partCosts[1], Parts.part.lookup(Hypergulator.partItems[1]), Hypergulator.partCosts[2], Parts.part.lookup(Hypergulator.partItems[2]), Hypergulator.partCosts[3], Parts.part.lookup(Hypergulator.partItems[3]), Hypergulator.repairStrength);
                if (checkMats("hypergulator"))
                    blueprintButton.GetComponent<Button>().interactable = true;
                else
                    blueprintButton.GetComponent<Button>().interactable = false;
                break;
            case "phasiomatic":
                updateButton(phasiomaticIcon, GlobalData.phasiomaticLevel, Phasiomatic.partCosts[0], Parts.part.lookup(Phasiomatic.partItems[0]), Phasiomatic.partCosts[1], Parts.part.lookup(Phasiomatic.partItems[1]), Phasiomatic.partCosts[2], Parts.part.lookup(Phasiomatic.partItems[2]), Phasiomatic.partCosts[3], Parts.part.lookup(Phasiomatic.partItems[3]), Phasiomatic.repairStrength);
                if (checkMats("phasiomatic"))
                    blueprintButton.GetComponent<Button>().interactable = true;
                else
                    blueprintButton.GetComponent<Button>().interactable = false;
                break;
            case "catatrans":
                updateButton(catatranslyticIcon, GlobalData.catatranslyticLevel, Catatrans.partCosts[0], Parts.part.lookup(Catatrans.partItems[0]), Catatrans.partCosts[1], Parts.part.lookup(Catatrans.partItems[1]), Catatrans.partCosts[2], Parts.part.lookup(Catatrans.partItems[2]), Catatrans.partCosts[3], Parts.part.lookup(Catatrans.partItems[3]), Catatrans.repairStrength);
                if (checkMats("catatrans"))
                    blueprintButton.GetComponent<Button>().interactable = true;
                else
                    blueprintButton.GetComponent<Button>().interactable = false;
                break;
            case "crosspneumo":
                updateButton(crosspneumaticclunkerIcon, GlobalData.crosspneumaticclunkerLevel, CrossPneumo.partCosts[0], Parts.part.lookup(CrossPneumo.partItems[0]), CrossPneumo.partCosts[1], Parts.part.lookup(CrossPneumo.partItems[1]), CrossPneumo.partCosts[2], Parts.part.lookup(CrossPneumo.partItems[2]), CrossPneumo.partCosts[3], Parts.part.lookup(CrossPneumo.partItems[3]), CrossPneumo.repairStrength);
                if (checkMats("crosspneumo"))
                    blueprintButton.GetComponent<Button>().interactable = true;
                else
                    blueprintButton.GetComponent<Button>().interactable = false;
                break;
            case "magneto":
                updateButton(magnetoconverterIcon, GlobalData.magnetoconverterLevel, Magneto.partCosts[0], Parts.part.lookup(Magneto.partItems[0]), Magneto.partCosts[1], Parts.part.lookup(Magneto.partItems[1]), Magneto.partCosts[2], Parts.part.lookup(Magneto.partItems[2]), Magneto.partCosts[3], Parts.part.lookup(Magneto.partItems[3]), Magneto.repairStrength);
                if (checkMats("magneto"))
                    blueprintButton.GetComponent<Button>().interactable = true;
                else
                    blueprintButton.GetComponent<Button>().interactable = false;
                break;
            case "photo":
                updateButton(photooscilatorIcon, GlobalData.photooscilatorLevel, PhotoOsc.partCosts[0], Parts.part.lookup(PhotoOsc.partItems[0]), PhotoOsc.partCosts[1], Parts.part.lookup(PhotoOsc.partItems[1]), PhotoOsc.partCosts[2], Parts.part.lookup(PhotoOsc.partItems[2]), PhotoOsc.partCosts[3], Parts.part.lookup(PhotoOsc.partItems[3]), PhotoOsc.repairStrength);
                if (checkMats("photo"))
                    blueprintButton.GetComponent<Button>().interactable = true;
                else
                    blueprintButton.GetComponent<Button>().interactable = false;
                break;
            default:
                blueprintButton.SetActive(false);
                break;
        }
    }

    public void repairMachine()
    {
        repairSound.Play();
        switch (activeRepair)
        {
            case "screncher":
                subtractMats(activeRepair);
                blueprintButton.SetActive(false);
                GlobalData.screncherIsBorked = false;
                GlobalData.screncherCraftsSinceRepair = 0;
                break;
            case "whomper":
                subtractMats(activeRepair);
                blueprintButton.SetActive(false);
                GlobalData.whomperIsBorked = false;
                GlobalData.whomperCraftsSinceRepair = 0;
                break;
            case "sprockonater":
                subtractMats(activeRepair);
                blueprintButton.SetActive(false);
                GlobalData.sprockonaterIsBorked = false;
                GlobalData.sprockonaterCraftsSinceRepair = 0;
                break;
            case "cranky":
                subtractMats(activeRepair);
                blueprintButton.SetActive(false);
                GlobalData.crankyIsBorked = false;
                GlobalData.crankyCraftsSinceRepair = 0;
                break;
            case "fidgitron":
                subtractMats(activeRepair);
                blueprintButton.SetActive(false);
                GlobalData.fidgitronIsBorked = false;
                GlobalData.fidgitronCraftsSinceRepair = 0;
                break;
            case "supertsx":
                subtractMats(activeRepair);
                blueprintButton.SetActive(false);
                GlobalData.supertsxIsBorked = false;
                GlobalData.supertsxCraftsSinceRepair = 0;
                break;
            case "hypergulator":
                subtractMats(activeRepair);
                blueprintButton.SetActive(false);
                GlobalData.hypergulatorIsBorked = false;
                GlobalData.hypergulatorCraftsSinceRepair = 0;
                break;
            case "phasiomatic":
                subtractMats(activeRepair);
                blueprintButton.SetActive(false);
                GlobalData.phasiomaticIsBorked = false;
                GlobalData.phasiomaticCraftsSinceRepair = 0;
                break;
            case "catatrans":
                subtractMats(activeRepair);
                blueprintButton.SetActive(false);
                GlobalData.catatranslyticCraftsSinceRepair = 0;
                GlobalData.catatranslyticIsBorked = false;
                break;
            case "crosspneumo":
                subtractMats(activeRepair);
                blueprintButton.SetActive(false);
                GlobalData.crosspneumaticclunkerCraftsSinceRepair = 0;
                GlobalData.crosspneumaticclunkerIsBorked = false;
                break;
            case "magneto":
                subtractMats(activeRepair);
                blueprintButton.SetActive(false);
                GlobalData.magnetoconverterIsBorked = false;
                GlobalData.magnetoconverterCraftsSinceRepair = 0;
                break;
            case "photo":
                subtractMats(activeRepair);
                blueprintButton.SetActive(false);
                GlobalData.photooscilatorIsBorked = false;
                GlobalData.photooscilatorCraftsSinceRepair = 0;
                break;
            default:
                blueprintButton.SetActive(false);
                break;
        }
    }

    public void updateButton(Sprite icon, int level, int part1Cost, Sprite part1icon, int part2Cost, Sprite part2icon, int part3Cost, Sprite part3icon, int part4Cost, Sprite part4icon, int strength)
    {
        machineImage.GetComponent<Image>().sprite = icon;
        partOneImage.GetComponent<Image>().sprite = part1icon;
        partOneText.GetComponent<Text>().text = Mathf.CeilToInt((part1Cost * level)/2).ToString();
        partTwoImage.GetComponent<Image>().sprite = part2icon;
        partTwoText.GetComponent<Text>().text = Mathf.CeilToInt((part2Cost * level)/2).ToString();
        if (strength >= 2)
        {
            partThreeImage.GetComponent<Image>().sprite = part3icon;
            partThreeText.GetComponent<Text>().text = Mathf.CeilToInt((part3Cost * level)/2).ToString();
            partThreeImage.GetComponent<Image>().enabled = true;
            partThreeText.GetComponent<Text>().enabled = true;
        }
        else
        {
            partThreeImage.GetComponent<Image>().enabled = false;
            partThreeText.GetComponent<Text>().enabled = false;
        }
        if (strength >= 3)
        {
            partFourImage.GetComponent<Image>().sprite = part4icon;
            partFourText.GetComponent<Text>().text = Mathf.CeilToInt((part4Cost * level)/2).ToString();
            partFourImage.GetComponent<Image>().enabled = true;
            partFourText.GetComponent<Text>().enabled = true;
        }
        else
        {
            partFourImage.GetComponent<Image>().enabled = false;
            partFourText.GetComponent<Text>().enabled = false;
        }


        blueprintButton.SetActive(true);
    }

    public bool checkMats(string machine)
    {
        switch (machine)
        {
            case "screncher":
                return checkParts(Screncher.partItems, Screncher.partCosts, GlobalData.screncherLevel, Screncher.repairStrength);

            case "whomper":
                return checkParts(Whomper.partItems, Whomper.partCosts, GlobalData.whomperLevel, Whomper.repairStrength);

            case "sprockonater":
                return checkParts(Sprockonater.partItems, Sprockonater.partCosts, GlobalData.sprockonaterLevel, Sprockonater.repairStrength);

            case "cranky":
                return checkParts(Cranky.partItems, Cranky.partCosts, GlobalData.crankyLevel, Cranky.repairStrength);

            case "fidgitron":
                return checkParts(Fidgitron.partItems, Fidgitron.partCosts, GlobalData.fidgitronLevel, Fidgitron.repairStrength);

            case "supertsx":
                return checkParts(SuperTSX.partItems, SuperTSX.partCosts, GlobalData.supertsxLevel, SuperTSX.repairStrength);

            case "hypergulator":
                return checkParts(Hypergulator.partItems, Hypergulator.partCosts, GlobalData.hypergulatorLevel, Hypergulator.repairStrength);

            case "phasiomatic":
                return checkParts(Phasiomatic.partItems, Phasiomatic.partCosts, GlobalData.phasiomaticLevel, Phasiomatic.repairStrength);

            case "catatrans":
                return checkParts(Catatrans.partItems, Catatrans.partCosts, GlobalData.catatranslyticLevel, Catatrans.repairStrength);

            case "crosspneumo":
                return checkParts(CrossPneumo.partItems, CrossPneumo.partCosts, GlobalData.crosspneumaticclunkerLevel, CrossPneumo.repairStrength);

            case "magneto":
                return checkParts(Magneto.partItems, Magneto.partCosts, GlobalData.magnetoconverterLevel, Magneto.repairStrength);

            case "photo":
                return checkParts(PhotoOsc.partItems, PhotoOsc.partCosts, GlobalData.photooscilatorLevel, PhotoOsc.repairStrength);

            default:
                return false;
        }
    }

    public bool checkParts(string[] parts, int[] cost, int level, int repair)
    {
        bool[] checks = new bool[4];

        for (int i = 0; i < 4; i++)
        {
            checks[i] = craftItem.checkMats(parts[i], Mathf.CeilToInt((cost[i] * level)/2));
        }
        if (repair == 1)
        {
            return checks[0] & checks[1];
        }
        else if (repair == 2)
        {
            return checks[0] & checks[1] & checks[2];
        }
        else
            return checks[0] & checks[1] & checks[2] & checks[3];
    }


    public void subtractMats(string machine)
    {
        switch (machine)
        {
            case "stayputer":
                for(int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(Stayputer.partItems[i], Stayputer.partCosts[i]);
                }
                break;
            case "screncher":
                for (int i = 0; i < (Screncher.repairStrength + 1); i++)
                {
                    craftItem.subtractMats(Screncher.partItems[i], Mathf.CeilToInt((Screncher.partCosts[i]* GlobalData.screncherLevel)/2));
                }
                break;
            case "whomper":
                for (int i = 0; i < (Whomper.repairStrength + 1); i++)
                {
                    craftItem.subtractMats(Whomper.partItems[i], Mathf.CeilToInt((Whomper.partCosts[i] * GlobalData.whomperLevel)/2));
                };
                break;
            case "sprokonater":
                for (int i = 0; i < (Sprockonater.repairStrength + 1); i++)
                {
                    craftItem.subtractMats(Sprockonater.partItems[i], Mathf.CeilToInt((Sprockonater.partCosts[i] * GlobalData.sprockonaterLevel)/2));
                }
                break;
            case "cranky":
                for (int i = 0; i < (Cranky.repairStrength + 1); i++)
                {
                    craftItem.subtractMats(Cranky.partItems[i], Mathf.CeilToInt((Cranky.partCosts[i] * GlobalData.crankyLevel)/2));
                }
                break;
            case "fidgitron":
                for (int i = 0; i < (Fidgitron.repairStrength + 1); i++)
                {
                    craftItem.subtractMats(Fidgitron.partItems[i], Mathf.CeilToInt((Fidgitron.partCosts[i] * GlobalData.fidgitronLevel)/2));
                }
                break;
            case "supertsx":
                for (int i = 0; i < (SuperTSX.repairStrength + 1); i++)
                {
                    craftItem.subtractMats(SuperTSX.partItems[i], Mathf.CeilToInt((SuperTSX.partCosts[i] * GlobalData.supertsxLevel)/2));
                }
                break;
            case "hypergulator":
                for (int i = 0; i < (Hypergulator.repairStrength + 1); i++)
                {
                    craftItem.subtractMats(Hypergulator.partItems[i], Mathf.CeilToInt((Hypergulator.partCosts[i] * GlobalData.hypergulatorLevel)/2));
                }
                break;
            case "phasiomatic":
                for (int i = 0; i < (Phasiomatic.repairStrength + 1); i++)
                {
                    craftItem.subtractMats(Phasiomatic.partItems[i], Mathf.CeilToInt((Phasiomatic.partCosts[i] * GlobalData.phasiomaticLevel)/2));
                }
                break;
            case "catatrans":
                for (int i = 0; i < (Catatrans.repairStrength + 1); i++)
                {
                    craftItem.subtractMats(Catatrans.partItems[i], Mathf.CeilToInt((Catatrans.partCosts[i] * GlobalData.catatranslyticLevel)/2));
                }
                break;
            case "crosspneumo":
                for (int i = 0; i < (CrossPneumo.repairStrength + 1); i++)
                {
                    craftItem.subtractMats(CrossPneumo.partItems[i], Mathf.CeilToInt((CrossPneumo.partCosts[i] * GlobalData.crosspneumaticclunkerLevel)/2));
                }
                break;
            case "magneto":
                for (int i = 0; i < (Magneto.repairStrength + 1); i++)
                {
                    craftItem.subtractMats(Magneto.partItems[i], Mathf.CeilToInt((Magneto.partCosts[i] * GlobalData.magnetoconverterLevel)/2));
                }
                break;
            case "photo":
                for (int i = 0; i < (PhotoOsc.repairStrength + 1); i++)
                {
                    craftItem.subtractMats(PhotoOsc.partItems[i], Mathf.CeilToInt((PhotoOsc.partCosts[i] * GlobalData.photooscilatorLevel)/2));
                }
                break;
            default:
                break;
        }
    }
}

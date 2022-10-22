using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueprintManager : MonoBehaviour
{

    public static string activeBlueprint = "none";

    public GameObject blueprintButton;
    public GameObject machineImage;
    public GameObject levelText;
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
    public Sprite stopperIcon;
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

    public AudioSource buildSound;

    // Update is called once per frame
    void Update()
    {
        switch (activeBlueprint)
        {
            case "stayputer":
                updateButton(stayputerIcon, 1, Stayputer.partCosts[0], Parts.part.lookup(Stayputer.partItems[0]), Stayputer.partCosts[1], Parts.part.lookup(Stayputer.partItems[1]), Stayputer.partCosts[2], Parts.part.lookup(Stayputer.partItems[2]), Stayputer.partCosts[3], Parts.part.lookup(Stayputer.partItems[3]));
                if (checkMats("stayputer"))
                {
                    blueprintButton.GetComponent<Button>().interactable = true;
                }
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "stopper":
                updateButton(stopperIcon, 1, Stopper.partCosts[0], Parts.part.lookup(Stopper.partItems[0]), Stopper.partCosts[1], Parts.part.lookup(Stopper.partItems[1]), Stopper.partCosts[2], Parts.part.lookup(Stopper.partItems[2]), Stopper.partCosts[3], Parts.part.lookup(Stopper.partItems[3]));
                if (checkMats("stopper")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "screncher":
                updateButton(screncherIcon, GlobalData.screncherLevel+1, Screncher.partCosts[0], Parts.part.lookup(Screncher.partItems[0]), Screncher.partCosts[1], Parts.part.lookup(Screncher.partItems[1]), Screncher.partCosts[2], Parts.part.lookup(Screncher.partItems[2]), Screncher.partCosts[3], Parts.part.lookup(Screncher.partItems[3]));
                if(checkMats("screncher")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "whomper":
                updateButton(whomperIcon, GlobalData.whomperLevel+1, Whomper.partCosts[0], Parts.part.lookup(Whomper.partItems[0]), Whomper.partCosts[1], Parts.part.lookup(Whomper.partItems[1]), Whomper.partCosts[2], Parts.part.lookup(Whomper.partItems[2]), Whomper.partCosts[3], Parts.part.lookup(Whomper.partItems[3]));
                if (checkMats("whomper")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "sprockonater":
                updateButton(sprockonaterIcon, GlobalData.sprockonaterLevel+1, Sprockonater.partCosts[0], Parts.part.lookup(Sprockonater.partItems[0]), Sprockonater.partCosts[1], Parts.part.lookup(Sprockonater.partItems[1]), Sprockonater.partCosts[2], Parts.part.lookup(Sprockonater.partItems[2]), Sprockonater.partCosts[3], Parts.part.lookup(Sprockonater.partItems[3]));
                if (checkMats("sprockonater")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "cranky":
                updateButton(crankyIcon, GlobalData.crankyLevel+1, Cranky.partCosts[0], Parts.part.lookup(Cranky.partItems[0]), Cranky.partCosts[1], Parts.part.lookup(Cranky.partItems[1]), Cranky.partCosts[2], Parts.part.lookup(Cranky.partItems[2]), Cranky.partCosts[3], Parts.part.lookup(Cranky.partItems[3]));
                if (checkMats("cranky")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "fidgitron":
                updateButton(fidgitronIcon, GlobalData.fidgitronLevel+1, Fidgitron.partCosts[0], Parts.part.lookup(Fidgitron.partItems[0]), Fidgitron.partCosts[1], Parts.part.lookup(Fidgitron.partItems[1]), Fidgitron.partCosts[2], Parts.part.lookup(Fidgitron.partItems[2]), Fidgitron.partCosts[3], Parts.part.lookup(Fidgitron.partItems[3]));
                if (checkMats("fidgitron")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "supertsx":
                updateButton(supertsxIcon, GlobalData.supertsxLevel+1, SuperTSX.partCosts[0], Parts.part.lookup(SuperTSX.partItems[0]), SuperTSX.partCosts[1], Parts.part.lookup(SuperTSX.partItems[1]), SuperTSX.partCosts[2], Parts.part.lookup(SuperTSX.partItems[2]), SuperTSX.partCosts[3], Parts.part.lookup(SuperTSX.partItems[3]));
                if (checkMats("supertsx")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "hypergulator":
                updateButton(hypergulatorIcon, GlobalData.hypergulatorLevel+1, Hypergulator.partCosts[0], Parts.part.lookup(Hypergulator.partItems[0]), Hypergulator.partCosts[1], Parts.part.lookup(Hypergulator.partItems[1]), Hypergulator.partCosts[2], Parts.part.lookup(Hypergulator.partItems[2]), Hypergulator.partCosts[3], Parts.part.lookup(Hypergulator.partItems[3]));
                if (checkMats("hypergulator")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "phasiomatic":
                updateButton(phasiomaticIcon, GlobalData.phasiomaticLevel+1, Phasiomatic.partCosts[0], Parts.part.lookup(Phasiomatic.partItems[0]), Phasiomatic.partCosts[1], Parts.part.lookup(Phasiomatic.partItems[1]), Phasiomatic.partCosts[2], Parts.part.lookup(Phasiomatic.partItems[2]), Phasiomatic.partCosts[3], Parts.part.lookup(Phasiomatic.partItems[3]));
                if (checkMats("phasiomatic")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "catatrans":
                updateButton(catatranslyticIcon, GlobalData.catatranslyticLevel+1, Catatrans.partCosts[0], Parts.part.lookup(Catatrans.partItems[0]), Catatrans.partCosts[1], Parts.part.lookup(Catatrans.partItems[1]), Catatrans.partCosts[2], Parts.part.lookup(Catatrans.partItems[2]), Catatrans.partCosts[3], Parts.part.lookup(Catatrans.partItems[3]));
                if (checkMats("catatrans")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "crosspneumo":
                updateButton(crosspneumaticclunkerIcon, GlobalData.crosspneumaticclunkerLevel+1, CrossPneumo.partCosts[0], Parts.part.lookup(CrossPneumo.partItems[0]), CrossPneumo.partCosts[1], Parts.part.lookup(CrossPneumo.partItems[1]), CrossPneumo.partCosts[2], Parts.part.lookup(CrossPneumo.partItems[2]), CrossPneumo.partCosts[3], Parts.part.lookup(CrossPneumo.partItems[3]));
                if (checkMats("crosspneumo")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "magneto":
                updateButton(magnetoconverterIcon, GlobalData.magnetoconverterLevel+1, Magneto.partCosts[0], Parts.part.lookup(Magneto.partItems[0]), Magneto.partCosts[1], Parts.part.lookup(Magneto.partItems[1]), Magneto.partCosts[2], Parts.part.lookup(Magneto.partItems[2]), Magneto.partCosts[3], Parts.part.lookup(Magneto.partItems[3]));
                if (checkMats("magneto")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            case "photo":
                updateButton(photooscilatorIcon, GlobalData.photooscilatorLevel+1, PhotoOsc.partCosts[0], Parts.part.lookup(PhotoOsc.partItems[0]), PhotoOsc.partCosts[1], Parts.part.lookup(PhotoOsc.partItems[1]), PhotoOsc.partCosts[2], Parts.part.lookup(PhotoOsc.partItems[2]), PhotoOsc.partCosts[3], Parts.part.lookup(PhotoOsc.partItems[3]));
                if (checkMats("photo")) blueprintButton.GetComponent<Button>().interactable = true;
                else
                {
                    blueprintButton.GetComponent<Button>().interactable = false;
                }
                break;
            default:
                blueprintButton.SetActive(false);
                break;
        }
    }

    public void buildMachine()
    {
        buildSound.Play();
        switch (activeBlueprint)
        {
            case "stayputer":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.stayputerBuilt = true;
                break;

            case "stopper":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.stopperBuilt = true;
                break;

            case "screncher":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.screncherBuilt = true;
                GlobalData.screncherLevel += 1;
                break;
            case "whomper":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.whomperBuilt = true;
                GlobalData.whomperLevel += 1;
                break;
            case "sprockonater":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.sprockonaterBuilt = true;
                GlobalData.sprockonaterLevel += 1;
                break;
            case "cranky":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.crankyBuilt = true;
                GlobalData.crankyLevel += 1;
                break;
            case "fidgitron":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.fidgitronBuilt = true;
                GlobalData.fidgitronLevel += 1;
                break;
            case "supertsx":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.supertsxBuilt = true;
                GlobalData.supertsxLevel += 1;
                break;
            case "hypergulator":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.hypergulatorBuilt = true;
                GlobalData.hypergulatorLevel += 1;
                break;
            case "phasiomatic":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.phasiomaticBuilt = true;
                GlobalData.phasiomaticLevel += 1;
                break;
            case "catatrans":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.catatranslyticBuilt = true;
                GlobalData.catatranslyticLevel += 1;
                break;
            case "crosspneumo":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.crosspneumaticclunkerBuilt = true;
                GlobalData.crosspneumaticclunkerLevel += 1;
                break;
            case "magneto":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.magnetoconverterBuilt = true;
                GlobalData.magnetoconverterLevel += 1;
                break;
            case "photo":
                subtractMats(activeBlueprint);
                blueprintButton.GetComponent<Button>().interactable = false;
                activeBlueprint = "none";
                MachineManager.photooscilatorBuilt = true;
                GlobalData.photooscilatorLevel += 1;
                break;
            default:
                blueprintButton.SetActive(false);
                break;
        }
    }

    public void updateButton(Sprite icon, int level, int part1Cost, Sprite part1icon, int part2Cost, Sprite part2icon, int part3Cost, Sprite part3icon, int part4Cost, Sprite part4icon)
    {
        machineImage.GetComponent<Image>().sprite = icon;
        levelText.GetComponent<Text>().text = level.ToString();
        partOneImage.GetComponent<Image>().sprite = part1icon;
        partOneText.GetComponent<Text>().text = (part1Cost*level).ToString();
        partTwoImage.GetComponent<Image>().sprite = part2icon;
        partTwoText.GetComponent<Text>().text = (part2Cost*level).ToString();
        partThreeImage.GetComponent<Image>().sprite = part3icon;
        partThreeText.GetComponent<Text>().text = (part3Cost*level).ToString();
        partFourImage.GetComponent<Image>().sprite = part4icon;
        partFourText.GetComponent<Text>().text = (part4Cost*level).ToString();
        blueprintButton.SetActive(true);
    }

    public bool checkMats(string machine)
    {
        switch (machine)
        {
            case "stayputer":
                return checkParts(Stayputer.partItems, Stayputer.partCosts, 0);

            case "stopper":
                return checkParts(Stopper.partItems, Stopper.partCosts, 0);

            case "screncher":
                return checkParts(Screncher.partItems, Screncher.partCosts, GlobalData.screncherLevel);

            case "whomper":
                return checkParts(Whomper.partItems, Whomper.partCosts, GlobalData.whomperLevel);

            case "sprockonater":
                return checkParts(Sprockonater.partItems, Sprockonater.partCosts, GlobalData.sprockonaterLevel);

            case "cranky":
                return checkParts(Cranky.partItems, Cranky.partCosts, GlobalData.crankyLevel);

            case "fidgitron":
                return checkParts(Fidgitron.partItems, Fidgitron.partCosts, GlobalData.fidgitronLevel);

            case "supertsx":
                return checkParts(SuperTSX.partItems, SuperTSX.partCosts, GlobalData.supertsxLevel);

            case "hypergulator":
                return checkParts(Hypergulator.partItems, Hypergulator.partCosts, GlobalData.hypergulatorLevel);

            case "phasiomatic":
                return checkParts(Phasiomatic.partItems, Phasiomatic.partCosts, GlobalData.phasiomaticLevel);

            case "catatrans":
                return checkParts(Catatrans.partItems, Catatrans.partCosts, GlobalData.catatranslyticLevel);

            case "crosspneumo":
                return checkParts(CrossPneumo.partItems, CrossPneumo.partCosts, GlobalData.crosspneumaticclunkerLevel);

            case "magneto":
                return checkParts(Magneto.partItems, Magneto.partCosts, GlobalData.magnetoconverterLevel);

            case "photo":
                return checkParts(PhotoOsc.partItems, PhotoOsc.partCosts, GlobalData.photooscilatorLevel);

            default:
                return false;
        }
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
            case "stopper":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(Stopper.partItems[i], Stopper.partCosts[i]);
                }
                break;
            case "screncher":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(Screncher.partItems[i], Screncher.partCosts[i]* (GlobalData.screncherLevel+1));
                }
                break;
            case "whomper":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(Whomper.partItems[i], Whomper.partCosts[i] * (GlobalData.whomperLevel+1));
                };
                break;
            case "sprockonater":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(Sprockonater.partItems[i], Sprockonater.partCosts[i] * (GlobalData.sprockonaterLevel+1));
                }
                break;
            case "cranky":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(Cranky.partItems[i], Cranky.partCosts[i] * (GlobalData.crankyLevel+1));
                }
                break;
            case "fidgitron":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(Fidgitron.partItems[i], Fidgitron.partCosts[i] * (GlobalData.fidgitronLevel+1));
                }
                break;
            case "supertsx":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(SuperTSX.partItems[i], SuperTSX.partCosts[i] * (GlobalData.supertsxLevel+1));
                }
                break;
            case "hypergulator":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(Hypergulator.partItems[i], Hypergulator.partCosts[i] * (GlobalData.hypergulatorLevel+1));
                }
                break;
            case "phasiomatic":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(Phasiomatic.partItems[i], Phasiomatic.partCosts[i] * (GlobalData.phasiomaticLevel+1));
                }
                break;
            case "catatrans":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(Catatrans.partItems[i], Catatrans.partCosts[i] * (GlobalData.catatranslyticLevel+1));
                }
                break;
            case "crosspneumo":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(CrossPneumo.partItems[i], CrossPneumo.partCosts[i] * (GlobalData.crosspneumaticclunkerLevel+1));
                }
                break;
            case "magneto":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(Magneto.partItems[i], Magneto.partCosts[i] * (GlobalData.magnetoconverterLevel+1));
                }
                break;
            case "photo":
                for (int i = 0; i < 4; i++)
                {
                    craftItem.subtractMats(PhotoOsc.partItems[i], PhotoOsc.partCosts[i] * (GlobalData.photooscilatorLevel+1));
                }
                break;
            default:
                break;
        }
    }

    public bool checkParts(string[] parts, int[] cost, int level)
    {
        bool[] checks = new bool[4];

        for (int i = 0; i < 4; i++)
        {
            checks[i] = craftItem.checkMats(parts[i], cost[i] * (level+1));
        }
        
        return checks[0] & checks[1] & checks[2] & checks[3];
    }
}

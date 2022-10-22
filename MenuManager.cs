using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public AudioSource click;
    public GameObject legendPanel;
    public bool activeLegendPanel = false;

    public static bool isLoading1 = false;
    public static bool isLoading2 = false;
    public static bool isLoading3 = false;
    public static bool isLoading4 = false;

    public void startGame()
    {
        click.Play();
        isLoading1 = false;
        isLoading2 = false;
        isLoading3 = false;
        isLoading4 = false;
        restart();
        SceneManager.LoadScene(2);
    }

    public static void restart()
    {
        GlobalData.playerLevel = 0;
        GlobalData.shinyCount = 0;
        GlobalData.rodCount = 25;
        GlobalData.plateCount = 10;
        GlobalData.springCount = -1;
        GlobalData.gearCount = -1;
        GlobalData.leverCount = -1;
        GlobalData.sprocketCount = -1;
        GlobalData.widgetCount = -1;
        GlobalData.gidgetCount = -1;
        GlobalData.doodadCount = -1;
        GlobalData.whizbangCount = -1;
        GlobalData.whatzitCount = -1;
        GlobalData.thingamajigCount = -1;
        GlobalData.gizmoCount = -1;
        GlobalData.gadgetCount = -1;

        GlobalData.maxWidgetCount = 0;
        GlobalData.maxGidgetCount = 0;
        GlobalData.maxDoodadCount = 0;
        GlobalData.maxWhizbangCount = 0;
        GlobalData.maxWhatzitCount = 0;
        GlobalData.maxThingamajigCount = 0;
        GlobalData.maxGizmoCount = 0;
        GlobalData.maxGadgetCount = 0;

        BlueprintManager.activeBlueprint = "none";

        ShopSell.material = 1;

        MachineManager.stayputerBuilt = false;
        MachineManager.stopperBuilt = false;
        MachineManager.screncherBuilt = false;
        MachineManager.whomperBuilt = false;
        MachineManager.sprockonaterBuilt = false;
        MachineManager.crankyBuilt = false;
        MachineManager.fidgitronBuilt = false;
        MachineManager.supertsxBuilt = false;
        MachineManager.hypergulatorBuilt = false;
        MachineManager.phasiomaticBuilt = false;
        MachineManager.catatranslyticBuilt = false;
        MachineManager.crosspneumaticclunkerBuilt = false;
        MachineManager.magnetoconverterBuilt = false;
        MachineManager.photooscilatorBuilt = false;

        GlobalData.screncherIsOn = false;
        GlobalData.screncherIsBorked = false;
        GlobalData.screncherCraftsSinceRepair = 0;
        GlobalData.screncherLevel = 0;
        Screncher.repairStrength = 0;

        GlobalData.whomperIsOn = false;
        GlobalData.whomperIsBorked = false;
        GlobalData.whomperCraftsSinceRepair = 0;
        GlobalData.whomperLevel = 0;
        Whomper.repairStrength = 0;

        GlobalData.sprockonaterIsOn = false;
        GlobalData.sprockonaterIsBorked = false;
        GlobalData.sprockonaterCraftsSinceRepair = 0;
        GlobalData.sprockonaterLevel = 0;
        Sprockonater.repairStrength = 0;

        GlobalData.crankyIsOn = false;
        GlobalData.crankyIsBorked = false;
        GlobalData.crankyCraftsSinceRepair = 0;
        GlobalData.crankyLevel =0;
        Cranky.repairStrength = 0;

        GlobalData.fidgitronIsOn = false;
        GlobalData.fidgitronIsBorked = false;
        GlobalData.fidgitronCraftsSinceRepair = 0;
        GlobalData.fidgitronLevel = 0;
        Fidgitron.repairStrength = 0;

        GlobalData.supertsxIsOn = false;
        GlobalData.supertsxIsBorked = false;
        GlobalData.supertsxCraftsSinceRepair = 0;
        GlobalData.supertsxLevel = 0;
        SuperTSX.repairStrength = 0;

        GlobalData.hypergulatorIsOn = false;
        GlobalData.hypergulatorIsBorked = false;
        GlobalData.hypergulatorCraftsSinceRepair = 0;
        GlobalData.hypergulatorLevel = 0;
        Hypergulator.repairStrength = 0;

        GlobalData.phasiomaticIsOn = false;
        GlobalData.phasiomaticIsBorked = false;
        GlobalData.phasiomaticCraftsSinceRepair = 0;
        GlobalData.phasiomaticLevel = 0;
        Phasiomatic.repairStrength = 0;

        GlobalData.catatranslyticIsOn = false;
        GlobalData.catatranslyticIsBorked = false;
        GlobalData.catatranslyticCraftsSinceRepair = 0;
        GlobalData.catatranslyticLevel = 0;
        Catatrans.repairStrength = 0;

        GlobalData.crosspneumaticclunkerIsOn = false;
        GlobalData.crosspneumaticclunkerIsBorked = false;
        GlobalData.crosspneumaticclunkerCraftsSinceRepair = 0;
        GlobalData.crosspneumaticclunkerLevel = 0;
        CrossPneumo.repairStrength = 0;

        GlobalData.magnetoconverterIsOn = false;
        GlobalData.magnetoconverterIsBorked = false;
        GlobalData.magnetoconverterCraftsSinceRepair = 0;
        GlobalData.magnetoconverterLevel = 0;
        Magneto.repairStrength = 0;

        GlobalData.photooscilatorIsOn = false;
        GlobalData.photooscilatorIsBorked = false;
        GlobalData.photooscilatorCraftsSinceRepair = 0;
        GlobalData.photooscilatorLevel = 0;
        PhotoOsc.repairStrength = 0;
    }

    public void startTut()
    {
        click.Play();
        SceneManager.LoadScene(1);
    }

    public void LoadFromMenu(int num)
    {
        if(num == 1)
        {
            isLoading1 = true;
            isLoading2 = false;
            isLoading3 = false;
            isLoading4 = false;
        }
        else if(num == 2)
        {
            isLoading1 = false;
            isLoading2 = true;
            isLoading3 = false;
            isLoading4 = false;
        }
        else if(num == 3)
        {
            isLoading1 = false;
            isLoading2 = false;
            isLoading3 = true;
            isLoading4 = false;
        }
        else if(num == 4)
        {
            isLoading1 = false;
            isLoading2 = false;
            isLoading3 = false;
            isLoading4 = true;
        }

        SceneManager.LoadScene(2);
    }

    public void LoadIt(int num)
    {
        LoadGame(num);
    }   

    public void LegendToggle()
    {
        if (activeLegendPanel)
        {
            legendPanel.SetActive(false);
            activeLegendPanel = false;
        }
        else
        {
            legendPanel.SetActive(true);
            activeLegendPanel = true;
        }
            
    }

    public void SaveIt(int num)
    {
        SaveGame(num);
    }

    

    public static void SaveGame(int num)
    {
        
        Save save = createSaveGameObject();

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/gamesave" + num + ".gf", FileMode.OpenOrCreate);
        bf.Serialize(file, save);
        file.Close();

    }


    public static void LoadGame(int num)
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave" + num + ".gf"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave" + num + ".gf", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            GlobalData.playerLevel = save.playerLevel;
            GlobalData.shinyCount = save.shinyCount;
            GlobalData.rodCount = save.rodCount;
            GlobalData.plateCount = save.plateCount;
            GlobalData.springCount = save.springCount;
            GlobalData.gearCount = save.gearCount;
            GlobalData.leverCount = save.leverCount;
            GlobalData.sprocketCount = save.sprocketCount; 
            GlobalData.widgetCount = save.widgetCount;
            GlobalData.gidgetCount = save.gidgetCount;
            GlobalData.doodadCount = save.doodadCount;
            GlobalData.whizbangCount = save.whizbangCount;
            GlobalData.whatzitCount = save.whatzitCount;
            GlobalData.thingamajigCount = save.thingamajigCount;
            GlobalData.gizmoCount = save.gizmoCount; 
            GlobalData.gadgetCount = save.gadgetCount;

            GlobalData.maxWidgetCount = save.maxWidgetCount;
            GlobalData.maxGidgetCount = save.maxGidgetCount;
            GlobalData.maxDoodadCount = save.maxDoodadCount;
            GlobalData.maxWhizbangCount = save.maxWhizbangCount;
            GlobalData.maxWhatzitCount = save.maxWhatzitCount;
            GlobalData.maxThingamajigCount = save.maxThingamajigCount;
            GlobalData.maxGizmoCount = save.maxGizmoCount;
            GlobalData.maxGadgetCount = save.maxGadgetCount;

            BlueprintManager.activeBlueprint = save.activeBlueprint;

            ShopSell.material = save.materialLevel;

            MachineManager.stayputerBuilt = save.stayputerBuilt;
            MachineManager.stopperBuilt = save.stopperBuilt;
            MachineManager.screncherBuilt = save.screncherBuilt;
            MachineManager.whomperBuilt = save.whomperBuilt;
            MachineManager.sprockonaterBuilt = save.sprockonaterBuilt;
            MachineManager.crankyBuilt = save.crankyBuilt;
            MachineManager.fidgitronBuilt = save.fidgitronBuilt;
            MachineManager.supertsxBuilt = save.supertsxBuilt;
            MachineManager.hypergulatorBuilt = save.hypergulator;
            MachineManager.phasiomaticBuilt = save.phasiomaticBuilt;
            MachineManager.catatranslyticBuilt = save.catatranslyticBuilt;
            MachineManager.crosspneumaticclunkerBuilt = save.crosspneumaticclunkerBuilt;
            MachineManager.magnetoconverterBuilt = save.magnetoconverterBuilt;
            MachineManager.photooscilatorBuilt = save.photooscilatorBuilt;

            GlobalData.screncherIsOn = save.screncherIsOn;
            GlobalData.screncherIsBorked = save.screncherIsBorked;
            GlobalData.screncherCraftsSinceRepair = save.screncherCraftsSinceRepair;
            GlobalData.screncherLevel = save.screncherLevel;
            Screncher.repairStrength = save.screncherRepair;

            GlobalData.whomperIsOn = save.whomperIsOn;
            GlobalData.whomperIsBorked = save.whomperIsBorked;
            GlobalData.whomperCraftsSinceRepair = save.whomperCraftsSinceRepair;
            GlobalData.whomperLevel = save.whomperLevel;
            Whomper.repairStrength = save.whomperRepair;

            GlobalData.sprockonaterIsOn = save.sprockonaterIsOn;
            GlobalData.sprockonaterIsBorked = save.sprockonaterIsBorked;
            GlobalData.sprockonaterCraftsSinceRepair = save.sprockonaterCraftsSinceRepair;
            GlobalData.sprockonaterLevel = save.sprockonaterLevel;
            Sprockonater.repairStrength = save.sprockonaterRepair;

            GlobalData.crankyIsOn = save.crankyIsOn;
            GlobalData.crankyIsBorked = save.crankyIsBorked;
            GlobalData.crankyCraftsSinceRepair = save.crankyCraftsSinceRepair;
            GlobalData.crankyLevel = save.crankyLevel;
            Cranky.repairStrength = save.crankyRepair;

            GlobalData.fidgitronIsOn = save.fidgitronIsOn;
            GlobalData.fidgitronIsBorked = save.fidgitronIsBorked;
            GlobalData.fidgitronCraftsSinceRepair = save.fidgitronCraftsSinceRepair;
            GlobalData.fidgitronLevel = save.fidgitronLevel;
            Fidgitron.repairStrength = save.fidgitronRepair;

            GlobalData.supertsxIsOn = save.supertsxIsOn;
            GlobalData.supertsxIsBorked = save.supertsxIsBorked;
            GlobalData.supertsxCraftsSinceRepair = save.supertsxCraftsSinceRepair;
            GlobalData.supertsxLevel = save.supertsxLevel;
            SuperTSX.repairStrength = save.supertsxRepair;

            GlobalData.hypergulatorIsOn = save.hypergulatorIsOn;
            GlobalData.hypergulatorIsBorked = save.hypergulatorIsBorked;
            GlobalData.hypergulatorCraftsSinceRepair = save.hypergulatorCraftsSinceRepair;
            GlobalData.hypergulatorLevel = save.hypergulatorLevel;
            Hypergulator.repairStrength = save.hypergulatorRepair;

            GlobalData.phasiomaticIsOn = save.phasiomaticIsOn;
            GlobalData.phasiomaticIsBorked = save.phasiomaticIsBorked;
            GlobalData.phasiomaticCraftsSinceRepair = save.phasiomaticCraftsSinceRepair;
            GlobalData.phasiomaticLevel = save.phasiomaticLevel;
            Phasiomatic.repairStrength = save.phasiomaticRepair;

            GlobalData.catatranslyticIsOn = save.catatranslyticIsOn;
            GlobalData.catatranslyticIsBorked = save.catatranslyticIsBorked;
            GlobalData.catatranslyticCraftsSinceRepair = save.catatranslyticCraftsSinceRepair;
            GlobalData.catatranslyticLevel = save.catatranslyticLevel;
            Catatrans.repairStrength = save.catatranslyticRepair;

            GlobalData.crosspneumaticclunkerIsOn = save.crosspneumaticclunkerIsOn;
            GlobalData.crosspneumaticclunkerIsBorked = save.crosspneumaticclunkerIsBorked;
            GlobalData.crosspneumaticclunkerCraftsSinceRepair = save.crosspneumaticclunkerCraftsSinceRepair;
            GlobalData.crosspneumaticclunkerLevel = save.crosspneumaticclunkerLevel;
            CrossPneumo.repairStrength = save.crosspneumaticclunkerRepair;

            GlobalData.magnetoconverterIsOn = save.magnetoconverterIsOn;
            GlobalData.magnetoconverterIsBorked = save.magnetoconverterIsBorked;
            GlobalData.magnetoconverterCraftsSinceRepair = save.magnetoconverterCraftsSinceRepair;
            GlobalData.magnetoconverterLevel = save.magnetoconverterLevel;
            Magneto.repairStrength = save.magnetoconverterRepair;

            GlobalData.photooscilatorIsOn = save.photooscilatorIsOn;
            GlobalData.photooscilatorIsBorked = save.photooscilatorIsBorked;
            GlobalData.photooscilatorCraftsSinceRepair = save.photooscilatorCraftsSinceRepair;
            GlobalData.photooscilatorLevel = save.photooscilatorLevel;
            PhotoOsc.repairStrength = save.photooscilatorRepair;       

        }
        else
        {
            isLoading1 = false;
            isLoading2 = false;
            isLoading3 = false;
            isLoading4 = false;
            SceneManager.LoadScene(2);
        }
    }

    private static Save createSaveGameObject()
    {
        Save save = new Save();

        save.playerLevel = GlobalData.playerLevel;
        save.shinyCount = GlobalData.shinyCount;
        save.rodCount = GlobalData.rodCount;
        save.plateCount = GlobalData.plateCount;
        save.springCount = GlobalData.springCount;
        save.gearCount = GlobalData.gearCount;
        save.leverCount = GlobalData.leverCount;
        save.sprocketCount = GlobalData.sprocketCount;
        save.widgetCount = GlobalData.widgetCount;
        save.gidgetCount = GlobalData.gidgetCount;
        save.doodadCount = GlobalData.doodadCount;
        save.whizbangCount = GlobalData.whizbangCount;
        save.whatzitCount = GlobalData.whatzitCount;
        save.thingamajigCount = GlobalData.thingamajigCount;
        save.gizmoCount = GlobalData.gizmoCount;
        save.gadgetCount = GlobalData.gadgetCount;

        save.maxWidgetCount = GlobalData.maxWidgetCount;
        save.maxGidgetCount = GlobalData.maxGidgetCount;
        save.maxDoodadCount = GlobalData.maxDoodadCount;
        save.maxWhizbangCount = GlobalData.maxWhizbangCount;
        save.maxWhatzitCount = GlobalData.maxWhatzitCount;
        save.maxThingamajigCount = GlobalData.maxThingamajigCount;
        save.maxGizmoCount = GlobalData.maxGizmoCount;
        save.maxGadgetCount = GlobalData.maxGadgetCount;

        save.activeBlueprint = BlueprintManager.activeBlueprint;

        save.materialLevel = ShopSell.material;

        save.stayputerBuilt = MachineManager.stayputerBuilt;
        save.stopperBuilt = MachineManager.stopperBuilt;
        save.screncherBuilt = MachineManager.screncherBuilt;
        save.whomperBuilt = MachineManager.whomperBuilt;
        save.sprockonaterBuilt = MachineManager.sprockonaterBuilt;
        save.crankyBuilt = MachineManager.crankyBuilt;
        save.fidgitronBuilt = MachineManager.fidgitronBuilt;
        save.supertsxBuilt = MachineManager.supertsxBuilt;
        save.hypergulator = MachineManager.hypergulatorBuilt;
        save.phasiomaticBuilt = MachineManager.phasiomaticBuilt;
        save.catatranslyticBuilt = MachineManager.catatranslyticBuilt;
        save.crosspneumaticclunkerBuilt = MachineManager.crosspneumaticclunkerBuilt;
        save.magnetoconverterBuilt = MachineManager.magnetoconverterBuilt;
        save.photooscilatorBuilt = MachineManager.photooscilatorBuilt;

        save.screncherIsOn = GlobalData.screncherIsOn;
        save.screncherIsBorked = GlobalData.screncherIsBorked;
        save.screncherCraftsSinceRepair = GlobalData.screncherCraftsSinceRepair;
        save.screncherLevel = GlobalData.screncherLevel;
        save.screncherRepair = Screncher.repairStrength;

        save.whomperIsOn = GlobalData.whomperIsOn;
        save.whomperIsBorked = GlobalData.whomperIsBorked;
        save.whomperCraftsSinceRepair = GlobalData.whomperCraftsSinceRepair;
        save.whomperLevel = GlobalData.whomperLevel;
        save.whomperRepair = Whomper.repairStrength;

        save.sprockonaterIsOn = GlobalData.sprockonaterIsOn;
        save.sprockonaterIsBorked = GlobalData.sprockonaterIsBorked;
        save.sprockonaterCraftsSinceRepair = GlobalData.sprockonaterCraftsSinceRepair;
        save.sprockonaterLevel = GlobalData.sprockonaterLevel;
        save.sprockonaterRepair = Sprockonater.repairStrength;

        save.crankyIsOn = GlobalData.crankyIsOn;
        save.crankyIsBorked = GlobalData.crankyIsBorked;
        save.crankyCraftsSinceRepair = GlobalData.crankyCraftsSinceRepair;
        save.crankyLevel = GlobalData.crankyLevel;
        save.crankyRepair = Cranky.repairStrength;

        save.fidgitronIsOn = GlobalData.fidgitronIsOn;
        save.fidgitronIsBorked = GlobalData.fidgitronIsBorked;
        save.fidgitronCraftsSinceRepair = GlobalData.fidgitronCraftsSinceRepair;
        save.fidgitronLevel = GlobalData.fidgitronLevel;
        save.fidgitronRepair = Fidgitron.repairStrength;

        save.supertsxIsOn = GlobalData.supertsxIsOn;
        save.supertsxIsBorked = GlobalData.supertsxIsBorked;
        save.supertsxCraftsSinceRepair = GlobalData.supertsxCraftsSinceRepair;
        save.supertsxLevel = GlobalData.supertsxLevel;
        save.supertsxRepair = SuperTSX.repairStrength;

        save.hypergulatorIsOn = GlobalData.hypergulatorIsOn;
        save.hypergulatorIsBorked = GlobalData.hypergulatorIsBorked;
        save.hypergulatorCraftsSinceRepair = GlobalData.hypergulatorCraftsSinceRepair;
        save.hypergulatorLevel = GlobalData.hypergulatorLevel;
        save.hypergulatorRepair = Hypergulator.repairStrength;

        save.phasiomaticIsOn = GlobalData.phasiomaticIsOn;
        save.phasiomaticIsBorked = GlobalData.phasiomaticIsBorked;
        save.phasiomaticCraftsSinceRepair = GlobalData.phasiomaticCraftsSinceRepair;
        save.phasiomaticLevel = GlobalData.phasiomaticLevel;
        save.phasiomaticRepair = Phasiomatic.repairStrength;

        save.catatranslyticIsOn = GlobalData.catatranslyticIsOn;
        save.catatranslyticIsBorked = GlobalData.catatranslyticIsBorked;
        save.catatranslyticCraftsSinceRepair = GlobalData.catatranslyticCraftsSinceRepair;
        save.catatranslyticLevel = GlobalData.catatranslyticLevel;
        save.catatranslyticRepair = Catatrans.repairStrength;

        save.crosspneumaticclunkerIsOn = GlobalData.crosspneumaticclunkerIsOn;
        save.crosspneumaticclunkerIsBorked = GlobalData.crosspneumaticclunkerIsBorked;
        save.crosspneumaticclunkerCraftsSinceRepair = GlobalData.crosspneumaticclunkerCraftsSinceRepair;
        save.crosspneumaticclunkerLevel = GlobalData.crosspneumaticclunkerLevel;
        save.crosspneumaticclunkerRepair = CrossPneumo.repairStrength;

        save.magnetoconverterIsOn = GlobalData.magnetoconverterIsOn;
        save.magnetoconverterIsBorked = GlobalData.magnetoconverterIsBorked;
        save.magnetoconverterCraftsSinceRepair = GlobalData.magnetoconverterCraftsSinceRepair;
        save.magnetoconverterLevel = GlobalData.magnetoconverterLevel;
        save.magnetoconverterRepair = Magneto.repairStrength;

        save.photooscilatorIsOn = GlobalData.photooscilatorIsOn;
        save.photooscilatorIsBorked = GlobalData.photooscilatorIsBorked;
        save.photooscilatorCraftsSinceRepair = GlobalData.photooscilatorCraftsSinceRepair;
        save.photooscilatorLevel = GlobalData.photooscilatorLevel;
        save.photooscilatorRepair = PhotoOsc.repairStrength;

        return save;
    }
}

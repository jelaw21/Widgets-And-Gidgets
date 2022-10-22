using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineManager : MonoBehaviour
{

    public static bool stayputerBuilt = false;

    public GameObject screncher;
    public static bool screncherBuilt = false;
    public Sprite screncherIcon;

    public GameObject stopper;
    public static bool stopperBuilt = false;
    public Sprite stopperIcon;

    public GameObject whomper;
    public static bool whomperBuilt = false;
    public Sprite whomperIcon;
    public GameObject sprockonater;
    public static bool sprockonaterBuilt  = false;
    public Sprite sprockonaterIcon;
    public GameObject cranky;
    public static bool crankyBuilt  = false;
    public Sprite crankyIcon;
    public GameObject fidgitron;
    public static bool fidgitronBuilt  = false;
    public Sprite fidgitronIcon;
    public GameObject supertsx;
    public static bool supertsxBuilt  = false;
    public Sprite supertsxIcon;
    public GameObject hypergulator;
    public static bool hypergulatorBuilt = false;
    public Sprite hypergulatorIcon;
    public GameObject phasiomatic;
    public static bool phasiomaticBuilt  = false;
    public Sprite phasiomaticIcon;
    public GameObject catatranslytic;
    public static bool catatranslyticBuilt  = false;
    public Sprite catatranslyticIcon;
    public GameObject crosspneumaticclunker;
    public static bool crosspneumaticclunkerBuilt  = false;
    public Sprite crosspneumaticclunkerIcon;
    public GameObject magnetoconverter;
    public static bool magnetoconverterBuilt  = false;
    public Sprite magnetoconverterIcon;
    public GameObject photooscilator;
    public static bool photooscilatorBuilt  = false;
    public Sprite photooscilatorIcon;

    public Sprite activated;
    public Sprite deactivated;
    public Sprite broken;

    public bool MachinesOn = false;

    private void Update()
    {
              
        if (stopperBuilt)
        {
            stopper.SetActive(true);            
        }
        else
            stopper.SetActive(false);

        if (screncherBuilt)
        {
            screncher.SetActive(true);
            if (GlobalData.screncherIsOn)
            {
                screncher.GetComponent<Image>().sprite = activated;
            }
            else
                screncher.GetComponent<Image>().sprite = deactivated;

            if (GlobalData.screncherIsBorked)
            {
                screncher.GetComponentsInChildren<Image>()[1].sprite = broken;
                screncher.GetComponent<Button>().interactable = false;
            }
            else
            {
                screncher.GetComponentsInChildren<Image>()[1].sprite = screncherIcon;
                screncher.GetComponent<Button>().interactable = true;
            }
        }
        else
            screncher.SetActive(false);

        if (whomperBuilt)
        {
            whomper.SetActive(true);
            if (GlobalData.whomperIsOn)
            {
                whomper.GetComponent<Image>().sprite = activated;
            }
            else
            {
                whomper.GetComponent<Image>().sprite = deactivated;
            }

            if (GlobalData.whomperIsBorked)
            {
                whomper.GetComponentsInChildren<Image>()[1].sprite = broken;
                whomper.GetComponent<Button>().interactable = false;
            }
            else
            {
                whomper.GetComponentsInChildren<Image>()[1].sprite = whomperIcon;
                whomper.GetComponent<Button>().interactable = true;
            }
                
        }
        else
           whomper.SetActive(false);

        if (sprockonaterBuilt)
        {
            sprockonater.SetActive(true);
            if (GlobalData.sprockonaterIsOn)
            {
                sprockonater.GetComponent<Image>().sprite = activated;
            }
            else
            {
                sprockonater.GetComponent<Image>().sprite = deactivated;
            }

            if (GlobalData.sprockonaterIsBorked)
            {
                sprockonater.GetComponentsInChildren<Image>()[1].sprite = broken;
                sprockonater.GetComponent<Button>().interactable = false;
            }
            else
            {
                sprockonater.GetComponentsInChildren<Image>()[1].sprite = sprockonaterIcon;
                sprockonater.GetComponent<Button>().interactable = true;
            }
                
        }
        else
            sprockonater.SetActive(false);

        if (crankyBuilt)
        {
            cranky.SetActive(true);
            if (GlobalData.crankyIsOn)
            {
                cranky.GetComponent<Image>().sprite = activated;
            }
            else
            {
                cranky.GetComponent<Image>().sprite = deactivated;
            }

            if (GlobalData.crankyIsBorked)
            {
                cranky.GetComponentsInChildren<Image>()[1].sprite = broken;
                cranky.GetComponent<Button>().interactable = false;
            }
            else
            {
                cranky.GetComponentsInChildren<Image>()[1].sprite = crankyIcon;
                cranky.GetComponent<Button>().interactable = true;
            }
                
        }
        else
            cranky.SetActive(false);

        if (fidgitronBuilt)
        {
            fidgitron.SetActive(true);
            if (GlobalData.fidgitronIsOn)
            {
                fidgitron.GetComponent<Image>().sprite = activated;
            }
            else
            {
                fidgitron.GetComponent<Image>().sprite = deactivated;
            }

            if (GlobalData.fidgitronIsBorked)
            {
                fidgitron.GetComponentsInChildren<Image>()[1].sprite = broken;
                fidgitron.GetComponent<Button>().interactable = false;
            }
            else
            {
                fidgitron.GetComponentsInChildren<Image>()[1].sprite = fidgitronIcon;
                fidgitron.GetComponent<Button>().interactable = true;
            }
        }
        else
            fidgitron.SetActive(false);


        if (supertsxBuilt)
        {
            supertsx.SetActive(true);
            if (GlobalData.supertsxIsOn)
            {
                supertsx.GetComponent<Image>().sprite = activated;
            }
            else
            {
                supertsx.GetComponent<Image>().sprite = deactivated;
            }
            if (GlobalData.supertsxIsBorked)
            {
                supertsx.GetComponentsInChildren<Image>()[1].sprite = broken;
                supertsx.GetComponent<Button>().interactable = false;
            }
            else
            {
                supertsx.GetComponentsInChildren<Image>()[1].sprite = supertsxIcon;
                supertsx.GetComponent<Button>().interactable = true;
            }
        }
        else
            supertsx.SetActive(false);

        if (hypergulatorBuilt)
        {
            hypergulator.SetActive(true);
            if (GlobalData.hypergulatorIsOn)
            {
                hypergulator.GetComponent<Image>().sprite = activated;
            }
            else
            {
                hypergulator.GetComponent<Image>().sprite = deactivated;
            }

            if (GlobalData.hypergulatorIsBorked)
            {
                hypergulator.GetComponentsInChildren<Image>()[1].sprite = broken;
                hypergulator.GetComponent<Button>().interactable = false;
            }
            else
            {
                hypergulator.GetComponentsInChildren<Image>()[1].sprite = hypergulatorIcon;
                hypergulator.GetComponent<Button>().interactable = true;
            }
        }
        else
            hypergulator.SetActive(false);

        if (phasiomaticBuilt)
        {
            phasiomatic.SetActive(true);
            if (GlobalData.phasiomaticIsOn)
            {
                phasiomatic.GetComponent<Image>().sprite = activated;
            }
            else
            {
                phasiomatic.GetComponent<Image>().sprite = deactivated;
            }

            if (GlobalData.phasiomaticIsBorked)
            {
                phasiomatic.GetComponentsInChildren<Image>()[1].sprite = broken;
                phasiomatic.GetComponent<Button>().interactable = false;
            }
            else
            {
                phasiomatic.GetComponentsInChildren<Image>()[1].sprite = phasiomaticIcon;
                phasiomatic.GetComponent<Button>().interactable = true;
            }
        }
        else
            phasiomatic.SetActive(false);

        if (catatranslyticBuilt)
        {
            catatranslytic.SetActive(true);
            if (GlobalData.catatranslyticIsOn)
            {
                catatranslytic.GetComponent<Image>().sprite = activated;
            }
            else
            {
                catatranslytic.GetComponent<Image>().sprite = deactivated;
            }
            if (GlobalData.catatranslyticIsBorked)
            {
                catatranslytic.GetComponentsInChildren<Image>()[1].sprite = broken;
                catatranslytic.GetComponent<Button>().interactable = false;
            }
            else
            {
                catatranslytic.GetComponentsInChildren<Image>()[1].sprite = catatranslyticIcon;
                catatranslytic.GetComponent<Button>().interactable = true;
            }
        }
        else
            catatranslytic.SetActive(false);

        if (crosspneumaticclunkerBuilt)
        {
            crosspneumaticclunker.SetActive(true);
            if (GlobalData.crosspneumaticclunkerIsOn)
            {
                crosspneumaticclunker.GetComponent<Image>().sprite = activated;
            }
            else
            {
                crosspneumaticclunker.GetComponent<Image>().sprite = deactivated;
            }

            if (GlobalData.crosspneumaticclunkerIsBorked)
            {
                crosspneumaticclunker.GetComponentsInChildren<Image>()[1].sprite = broken;
                crosspneumaticclunker.GetComponent<Button>().interactable = false;
            }
            else
            {
                crosspneumaticclunker.GetComponentsInChildren<Image>()[1].sprite = crosspneumaticclunkerIcon;
                crosspneumaticclunker.GetComponent<Button>().interactable = true;
            }
        }
        else
            crosspneumaticclunker.SetActive(false);

        if (magnetoconverterBuilt)
        {
            magnetoconverter.SetActive(true);
            if (GlobalData.magnetoconverterIsOn)
            {
                magnetoconverter.GetComponent<Image>().sprite = activated;
            }
            else
            {
                magnetoconverter.GetComponent<Image>().sprite = deactivated;
            }

            if (GlobalData.magnetoconverterIsBorked)
            {
                magnetoconverter.GetComponentsInChildren<Image>()[1].sprite = broken;
                magnetoconverter.GetComponent<Button>().interactable = false;
            }
            else
            {
                magnetoconverter.GetComponentsInChildren<Image>()[1].sprite = magnetoconverterIcon;
                magnetoconverter.GetComponent<Button>().interactable = true;
            }
                
        }
        else
            magnetoconverter.SetActive(false);

        if (photooscilatorBuilt)
        {
            photooscilator.SetActive(true);
            if (GlobalData.photooscilatorIsOn)
            {
                photooscilator.GetComponent<Image>().sprite = activated;
            }
            else
            {
                photooscilator.GetComponent<Image>().sprite = deactivated;
            }

            if (GlobalData.photooscilatorIsBorked)
            {
                photooscilator.GetComponentsInChildren<Image>()[1].sprite = broken;
                photooscilator.GetComponent<Button>().interactable = false;
            }
            else
            {
                photooscilator.GetComponentsInChildren<Image>()[1].sprite = photooscilatorIcon;
                photooscilator.GetComponent<Button>().interactable = true;
            }
        }
        else
            photooscilator.SetActive(false);

    }

        
    public void screncherPower()
    {
        if (GlobalData.screncherIsOn)
        {
            GlobalData.screncherIsOn = false;
        }
        else
        {
            GlobalData.screncherIsOn = true;
        }
    }

    public void whomperPower()
    {
        if (GlobalData.whomperIsOn)
        {
            GlobalData.whomperIsOn = false;
        }
        else
        {
            GlobalData.whomperIsOn = true;
        }

    }

    public void sprockonaterPower()
    {
        if (GlobalData.sprockonaterIsOn)
        {
            GlobalData.sprockonaterIsOn = false;
        }
        else
        {
            GlobalData.sprockonaterIsOn = true;
        }
    }

    public void crankyPower()
    {
        if (GlobalData.crankyIsOn)
        {
            GlobalData.crankyIsOn = false;
        }
        else
        {
            GlobalData.crankyIsOn = true;
        }

    }

    public void fidgitronPower()
    {
        if (GlobalData.fidgitronIsOn)
        {
            GlobalData.fidgitronIsOn = false;
        }
        else
        {
            GlobalData.fidgitronIsOn = true;
        }

    }

    public void supertsxPower()
    {
        if (GlobalData.supertsxIsOn)
        {
            GlobalData.supertsxIsOn = false;
        }
        else
        {
            GlobalData.supertsxIsOn = true;
        }

    }

    public void hypergulatorPower()
    {
        if (GlobalData.hypergulatorIsOn)
        {
            GlobalData.hypergulatorIsOn = false;
        }
        else
        {
            GlobalData.hypergulatorIsOn = true;
        }

    }

    public void phasiomaticPower()
    {
        if (GlobalData.phasiomaticIsOn)
        {
            GlobalData.phasiomaticIsOn = false;
        }
        else
        {
            GlobalData.phasiomaticIsOn = true;
        }

    }

    public void catatranslyticPower()
    {
        if (GlobalData.catatranslyticIsOn)
        {
            GlobalData.catatranslyticIsOn = false;
        }
        else
        {
            GlobalData.catatranslyticIsOn = true;
        }

    }

    public void crosspneumaticclunkerPower()
    {
        if (GlobalData.crosspneumaticclunkerIsOn)
        {
            GlobalData.crosspneumaticclunkerIsOn = false;
        }
        else
        {
            GlobalData.crosspneumaticclunkerIsOn = true;
        }

    }

    public void magnetoconverterPower()
    {
        if (GlobalData.magnetoconverterIsOn)
        {
            GlobalData.magnetoconverterIsOn = false;
        }
        else
        {
            GlobalData.magnetoconverterIsOn = true;
        }

    }

    public void photooscilatorPower()
    {
        if (GlobalData.photooscilatorIsOn)
        {
            GlobalData.photooscilatorIsOn = false;
        }
        else
        {
            GlobalData.photooscilatorIsOn = true;
        }

    }





}

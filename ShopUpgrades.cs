using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopUpgrades : MonoBehaviour
{
    public GameObject stayputBtn;
    public GameObject stopperBtn;
    public GameObject materialBtn;
    public GameObject screncherBtn;
    public GameObject whomperBtn;
    public GameObject sprocknaterBtn;
    public GameObject crankyBtn;
    public GameObject fidgitronBtn;
    public GameObject supertsxBtn;
    public GameObject hypergulatorBtn;
    public GameObject phasiomaticBtn;
    public GameObject catatransBtn;
    public GameObject crosspneumoBtn;
    public GameObject magnetoBtn;
    public GameObject photoBtn;

    public int stayputCost = 5;
    public int stopperCost = 10;
    public int materialCost = 250;
    public int screncherCost = 10;
    public int whomperCost = 10;
    public int sprockonaterCost = 15;
    public int crankyCost = 15;
    public int fidgetronCost = 20;
    public int supertsxCost = 40;
    public int hypergulatorCost = 60;
    public int phasiomaticCost = 80;
    public int catatransCost = 90;
    public int crosspneumoCost = 110;
    public int magnetoCost = 150;
    public int photoCost = 300;

    public AudioSource purchaseSound;


    public void purchaseMaterials()
    {   
        GlobalData.shinyCount -= materialCost * (int)(Mathf.Pow(5, ShopSell.material));
        ShopSell.material += 1;        
    }    
    
    public void buyStayputer()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "stayputer";
        stayputBtn.SetActive(false);
        GlobalData.shinyCount -= stayputCost;
    }

    public void buyStopper()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "stopper";
        stopperBtn.SetActive(false);
        GlobalData.shinyCount -= stopperCost;
    }

    public void buyScrencher()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "screncher";
        GlobalData.shinyCount -= screncherCost * (GlobalData.screncherLevel+1);
    }

    public void buyWhomper()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "whomper";
        GlobalData.shinyCount -= whomperCost * (GlobalData.whomperLevel+1);
    }

    public void buySprockonater()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "sprockonater";
        GlobalData.shinyCount -= sprockonaterCost * (GlobalData.sprockonaterLevel+1);
    }

    public void buyCranky()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "cranky";
        GlobalData.shinyCount -= crankyCost * (GlobalData.crankyLevel+1);
    }

    public void buyFidgitron()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "fidgitron";
        GlobalData.shinyCount -= fidgetronCost * (GlobalData.fidgitronLevel+1);
    }

    public void buySuperTSX()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "supertsx";
        GlobalData.shinyCount -= supertsxCost * (GlobalData.supertsxLevel+1);
    }

    public void buyHypergulator()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "hypergulator";
        GlobalData.shinyCount -= hypergulatorCost * (GlobalData.hypergulatorLevel+1);
    }

    public void buyPhasiomatic()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "phasiomatic";
        GlobalData.shinyCount -= phasiomaticCost * (GlobalData.phasiomaticLevel+1);
    }

    public void buyCataTranslytic()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "catatrans";
        GlobalData.shinyCount -= catatransCost * (GlobalData.catatranslyticLevel+1);
    }

    public void buyCrossPneumaticClunker()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "crosspneumo";
        GlobalData.shinyCount -= crosspneumoCost * (GlobalData.crosspneumaticclunkerLevel+1);
    }

    public void buyMagnetoConverter()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "magneto";
        GlobalData.shinyCount -= magnetoCost * (GlobalData.magnetoconverterLevel+1);
    }

    public void buyPhotoOscilator()
    {
        purchaseSound.Play();
        BlueprintManager.activeBlueprint = "photo";
        GlobalData.shinyCount -= photoCost * (GlobalData.photooscilatorLevel+1);
    }

    public void Update()
    {
        updateMaterialButton(materialBtn, ShopSell.material, materialCost, 1, 13, 17, 21, 24);
        UpdateStayPutBtn(stayputBtn, -1, stayputCost);
        UpdateStayPutBtn(stopperBtn, -1, stopperCost);
        updateShopButton(screncherBtn, GlobalData.screncherLevel, screncherCost, 8,11,14,18,20);
        updateShopButton(whomperBtn, GlobalData.whomperLevel, whomperCost,8,11,14,18,20);
        updateShopButton(sprocknaterBtn, GlobalData.sprockonaterLevel, sprockonaterCost,8,11,14,18,21);
        updateShopButton(crankyBtn, GlobalData.crankyLevel, crankyCost,8,11,14,18,21);
        updateShopButton(fidgitronBtn, GlobalData.fidgitronLevel, fidgetronCost,9,12,15,19,22);
        updateShopButton(supertsxBtn, GlobalData.supertsxLevel, supertsxCost,9,12,15,19,22);
        updateShopButton(hypergulatorBtn, GlobalData.hypergulatorLevel, hypergulatorCost,10,13,16,19,22);
        updateShopButton(phasiomaticBtn, GlobalData.phasiomaticLevel, phasiomaticCost,12,15,18,20,22);
        updateShopButton(catatransBtn, GlobalData.catatranslyticLevel, catatransCost,13,16,19,21,23);
        updateShopButton(crosspneumoBtn, GlobalData.crosspneumaticclunkerLevel, crosspneumoCost,14,17,19,21,23);
        updateShopButton(magnetoBtn, GlobalData.magnetoconverterLevel, magnetoCost,16,18,20,22,24);
        updateShopButton(photoBtn, GlobalData.photooscilatorLevel, photoCost,18,19,21,22,24);
    }

    public void UpdateStayPutBtn(GameObject button, int level, int cost)
    {
    
        Text[] textBoxes;
        textBoxes = button.GetComponentsInChildren<Text>();

        GameObject screen;
        screen = button.transform.Find("levelScreen").gameObject;
        if(GlobalData.playerLevel >= 6)
        {
            screen.SetActive(false);
            if (!BlueprintManager.activeBlueprint.Equals("none"))
            {
                screen.SetActive(true);
                screen.GetComponentInChildren<Text>().text = "Only 1 Active Blueprint Allowed";
                button.GetComponent<Button>().interactable = false;
                
            }
            else
            {
                if(GlobalData.shinyCount >= (cost))
                {
                    button.GetComponent<Button>().interactable = true;
                }
                else
                    button.GetComponent<Button>().interactable = false;
            }
        }
        else
        {
            screen.SetActive(true);
            screen.GetComponentInChildren<Text>().text = "Reach Level 6 To Unlock";
            button.GetComponent<Button>().interactable = false;
        }
        

        textBoxes[3].text = cost.ToString();
    }
    public void updateShopButton(GameObject button, int level, int cost, int oneReq, int twoReq, int threeReq, int fourReq, int fiveReq)
    {   
        Text[] textBoxes;        
        textBoxes = button.GetComponentsInChildren<Text>();

        GameObject screen;
        screen = button.transform.Find("levelScreen").gameObject;

        if(level == 4 & GlobalData.playerLevel < fiveReq)
        {
            screen.SetActive(true);
            screen.GetComponentInChildren<Text>().text = "Reach Level " + fiveReq + " To Unlock";
            button.GetComponent<Button>().interactable = false;
        }
        else if (level == 3 & GlobalData.playerLevel < fourReq)
        {
            screen.SetActive(true);
            screen.GetComponentInChildren<Text>().text = "Reach Level " + fourReq + " To Unlock";
            button.GetComponent<Button>().interactable = false;
        }
        else if (level == 2 & GlobalData.playerLevel < threeReq)
        {
            screen.SetActive(true);
            screen.GetComponentInChildren<Text>().text = "Reach Level " + threeReq + " To Unlock";
            button.GetComponent<Button>().interactable = false;
        }
        else if (level == 1 & GlobalData.playerLevel < twoReq)
        {
            screen.SetActive(true);
            screen.GetComponentInChildren<Text>().text = "Reach Level " + twoReq + " To Unlock";
            button.GetComponent<Button>().interactable = false;
        }
        else if (level == 0 & GlobalData.playerLevel < oneReq)
        {
            screen.SetActive(true);
            screen.GetComponentInChildren<Text>().text = "Reach Level " + oneReq + " To Unlock";
            button.GetComponent<Button>().interactable = false;
        }
        else
        {
            screen.SetActive(false);
            if (!BlueprintManager.activeBlueprint.Equals("none"))
            {   
                screen.SetActive(true);
                screen.GetComponentInChildren<Text>().text = "Only 1 Active Blueprint Allowed";
                button.GetComponent<Button>().interactable = false;
                
            }
            else
            {
                if(GlobalData.shinyCount >= (cost * (level + 1)))
                {
                    button.GetComponent<Button>().interactable = true;
                }
                else
                {
                    button.GetComponent<Button>().interactable = false;
                }
            }
        }        

        if (level < 5)
        {
            if (level >= 1)
            {
                textBoxes[1].text = benefitLookUp(level+1);
            }
            textBoxes[2].text = (level + 1).ToString();
            textBoxes[3].text = (cost * (level+1)).ToString();
        }
        else
            button.SetActive(false);
    }

    public void updateMaterialButton(GameObject button, int level, int cost, int oneReq, int twoReq, int threeReq, int fourReq, int fiveReq)
    {
        Text[] textBoxes;
        textBoxes = button.GetComponentsInChildren<Text>();

        GameObject screen;
        screen = button.transform.Find("levelScreen").gameObject;

        if (level == 4 & GlobalData.playerLevel < fiveReq)
        {
            screen.SetActive(true);
            screen.GetComponentInChildren<Text>().text = "Reach Level " + fiveReq + " To Unlock";
            button.GetComponent<Button>().interactable = false;
        }
        else if (level == 3 & GlobalData.playerLevel < fourReq)
        {
            screen.SetActive(true);
            screen.GetComponentInChildren<Text>().text = "Reach Level " + fourReq + " To Unlock";
            button.GetComponent<Button>().interactable = false;
        }
        else if (level == 2 & GlobalData.playerLevel < threeReq)
        {
            screen.SetActive(true);
            screen.GetComponentInChildren<Text>().text = "Reach Level " + threeReq + " To Unlock";
            button.GetComponent<Button>().interactable = false;
        }
        else if (level == 1 & GlobalData.playerLevel < twoReq)
        {
            screen.SetActive(true);
            screen.GetComponentInChildren<Text>().text = "Reach Level " + twoReq + " To Unlock";
            button.GetComponent<Button>().interactable = false;
        }
        else
        {
            screen.SetActive(false);            
            if (GlobalData.shinyCount >= (cost * Mathf.Pow(5,level)))
            {
                button.GetComponent<Button>().interactable = true;
            }
            else
            {
                button.GetComponent<Button>().interactable = false;
            }
        }

        if (level < 5)
        {
            if(level >= 4)
            {
                textBoxes[1].text = "Doubles Profits\nIncreases Costs";
                textBoxes[0].text = "Adamantium Parts";
            }
            else if(level >= 3)
            {
                textBoxes[1].text = "Doubles Profits\nIncreases Costs";
                textBoxes[0].text = "Titanium Parts";
            }
            else if(level >= 2)
            {
                textBoxes[1].text = "Doubles Profits\nIncreases Costs";
                textBoxes[0].text = "Steel Parts";
            }
            else if (level >= 1)
            {
                textBoxes[1].text = "Doubles Profits\nIncreases Costs";
                textBoxes[0].text = "Iron Parts";
            }
            
            textBoxes[3].text = (cost * Mathf.Pow(5, level)).ToString();
        }
        else
            button.SetActive(false);
    }

    public string benefitLookUp(int level)
    {
        switch (level)
        {
            case 2:
                return "+1 Craft Per Second";
            case 3:
                return "+1 Craft Per Second";
            case 4:
                return "+1 Extra Craft\n+1 Craft Per Second";
            case 5:
                return "+1 Extra Craft\n+1 Craft Per Second";
            default:
                return "none";
        }
    }


}

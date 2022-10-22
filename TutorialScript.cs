using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public GameObject crafting;
    public GameObject recipes;
    public GameObject shop;
    public GameObject shopPartsToShinies;
    public GameObject shopShiniesToParts;
    public GameObject shopUpgradePanel;
    public GameObject shopParts;
    public GameObject shopShiny;
    public GameObject shopUpgrade;
    public GameObject blueprints;
    public GameObject machines;
    public GameObject objectives;
    public GameObject failure;

    public GameObject blueprintArrow;
    public GameObject machineArrow;
    public GameObject objectiveArrow;

    public GameObject machinePanel;
    public GameObject craftingPanel;
    public GameObject recipePanel;
    public GameObject buttonPanel;
    public GameObject startPanel;
    public GameObject endPanel;

    public GameObject nextBtn1;
    public GameObject nextBtn2;

    public AudioSource click;

    public int count = -1;
    void Start()
    {
        GlobalData.playerLevel = 9;
        MachineManager.screncherBuilt = true;
        MachineManager.whomperBuilt = true;
        startPanel.SetActive(true);
    }

    void Update()
    {
        switch (count)
        {
            case 0:
                startPanel.SetActive(false);
                buttonPanel.SetActive(true);
                machinePanel.SetActive(true);
                crafting.SetActive(true);
                nextBtn1.SetActive(true);
                craftingPanel.SetActive(false);
                break;
            case 1:
                recipePanel.SetActive(false);
                craftingPanel.SetActive(true);
                crafting.SetActive(false);
                recipes.SetActive(true);
                break;
            case 2:
                craftingPanel.SetActive(false);
                recipePanel.SetActive(true);
                buttonPanel.SetActive(false);
                recipes.SetActive(false);
                shop.SetActive(true);
                shopParts.SetActive(true);
                nextBtn1.SetActive(false);
                nextBtn2.SetActive(true);
                break;
            case 3:
                shopPartsToShinies.SetActive(false);
                shopParts.SetActive(false);
                shopShiniesToParts.SetActive(true);
                shopShiny.SetActive(true);
                break;
            case 4:
                shopShiniesToParts.SetActive(false);
                shopShiny.SetActive(false);
                shopUpgradePanel.SetActive(true);
                shopUpgrade.SetActive(true);
                break;
            case 5:
                nextBtn2.SetActive(false);
                nextBtn1.SetActive(true);
                craftingPanel.SetActive(true);
                machinePanel.SetActive(false);
                shop.SetActive(false);
                shopUpgrade.SetActive(false);
                buttonPanel.SetActive(true);
                blueprints.SetActive(true);
                blueprintArrow.SetActive(true);
                break;
            case 6:
                blueprints.SetActive(false);
                blueprintArrow.SetActive(false);
                machines.SetActive(true);
                machineArrow.SetActive(true);
                break;
            case 7:
                machines.SetActive(false);
                machineArrow.SetActive(false);
                objectives.SetActive(true);
                objectiveArrow.SetActive(true);
                break;
            case 8:
                objectives.SetActive(false);
                objectiveArrow.SetActive(false);
                machinePanel.SetActive(true);
                failure.SetActive(true);
                break;
            case 9:
                failure.SetActive(false);
                endPanel.SetActive(true);
                break;
            default:
                break;

        }
    }

    public void nextTutorial()
    {
        click.Play();
        count += 1;
    }

    public void exitTutorial()
    {
        click.Play();
        MenuManager.isLoading1 = false;
        MenuManager.isLoading2 = false;
        MenuManager.isLoading3 = false;
        MenuManager.isLoading4 = false;
        MenuManager.restart();
        SceneManager.LoadScene(2);
        
    }
}

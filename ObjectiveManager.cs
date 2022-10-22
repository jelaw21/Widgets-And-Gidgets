using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjectiveManager : MonoBehaviour
{
    public GameObject goalText;
    public GameObject levelText;
    public GameObject partToMake;
    public GameObject objBtn;

    public Sprite shiny;
    public Sprite plate;
    public Sprite spring;
    public Sprite gear;
    public Sprite lever;
    public Sprite sprocket;
    public Sprite widget;
    public Sprite gidget;
    public Sprite doodad;
    public Sprite whizbang;
    public Sprite whatzit;
    public Sprite thingamajig;
    public Sprite gizmo;
    public Sprite gadget;

    public AudioSource objectiveComplete;

    private void Start()
    {
        objBtn.GetComponent<Button>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (GlobalData.playerLevel)
        {
            case 0:
                goalText.GetComponent<Text>().text = "Goal: 1 Spring";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = spring;
                if (craftItem.checkMats("spring", 1))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 1:
                goalText.GetComponent<Text>().text = "Goal: 4 Springs";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = spring;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (craftItem.checkMats("spring", 4))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 2:
                goalText.GetComponent<Text>().text = "Goal: 6 Gears";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = gear;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (craftItem.checkMats("gear", 6))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 3:
                goalText.GetComponent<Text>().text = "Goal: 4 Sprockets";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = sprocket;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (craftItem.checkMats("sprocket", 4))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 4:
                goalText.GetComponent<Text>().text = "Goal: 2 Levers";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = lever;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (craftItem.checkMats("lever", 2))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 5:
                goalText.GetComponent<Text>().text = "Goal: 2 Widgets";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = widget;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (craftItem.checkMats("widget", 2))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 6:
                goalText.GetComponent<Text>().text = "Goal: 5 Shinnies";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = shiny;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (GlobalData.shinyCount >= 5)
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 7:
                goalText.GetComponent<Text>().text = "Goal: 1 Gidget";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = gidget;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (craftItem.checkMats("gidget", 1))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 8:
                goalText.GetComponent<Text>().text = "Goal: 15 Shinnies";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = shiny;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (GlobalData.shinyCount >= 15)
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 9:
                goalText.GetComponent<Text>().text = "Goal: 4 Doodads";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = doodad;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (craftItem.checkMats("doodad", 4))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 10:
                goalText.GetComponent<Text>().text = "Goal: 50 Shinnies";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = shiny;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (GlobalData.shinyCount >= 50)
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 11:
                goalText.GetComponent<Text>().text = "Goal: 5 Whizbangs";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = whizbang;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (craftItem.checkMats("whizbang", 5))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 12:
                goalText.GetComponent<Text>().text = "Goal: 10 Whatzits";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = whatzit;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (craftItem.checkMats("whatzit", 10))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 13:
                goalText.GetComponent<Text>().text = "Goal: 10 Thingamajigs";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = thingamajig;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (craftItem.checkMats("thingamajig", 10))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 14:
                goalText.GetComponent<Text>().text = "Goal: 750 Shinnies";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = shiny;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (GlobalData.shinyCount >= 725)
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 15:
                goalText.GetComponent<Text>().text = "Goal: 12 Gizmo";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = gizmo;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (craftItem.checkMats("gizmo", 12))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;

            case 16:
                goalText.GetComponent<Text>().text = "Goal: 1,500 Shinnies";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = shiny;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (GlobalData.shinyCount >= 1500)
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;

            case 17:
                goalText.GetComponent<Text>().text = "Goal: 15 Gadget";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = gadget;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (craftItem.checkMats("gadget", 15))
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            
            case 18:
                goalText.GetComponent<Text>().text = "Goal: 5,000 Shinnies";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = shiny;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (GlobalData.shinyCount >= 5000)
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 19:
                goalText.GetComponent<Text>().text = "Goal: 25,000";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = shiny;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (GlobalData.shinyCount >= 25000)
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 20:
                goalText.GetComponent<Text>().text = "Goal: 50,000";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = shiny;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (GlobalData.shinyCount >= 50000)
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 21:
                goalText.GetComponent<Text>().text = "Goal: 100,000";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = shiny;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (GlobalData.shinyCount >= 100000)
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 22:
                goalText.GetComponent<Text>().text = "Goal: 250,000";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = shiny;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (GlobalData.shinyCount >= 250000)
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 23:
                goalText.GetComponent<Text>().text = "Goal: 500,000";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = shiny;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (GlobalData.shinyCount >= 500000)
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 24:
                goalText.GetComponent<Text>().text = "Goal: 1,000,000";
                levelText.GetComponent<Text>().text = "Next Level: " + (GlobalData.playerLevel + 1);
                partToMake.GetComponent<Image>().sprite = shiny;
                goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                if (GlobalData.shinyCount >= 1000000)
                {
                    objBtn.GetComponent<Button>().interactable = true;
                    goalText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    levelText.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                }
                else
                {
                    objBtn.GetComponent<Button>().interactable = false;
                    goalText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                    levelText.GetComponent<Text>().color = new Color(0.1906f, 0.1960f, 0.1960f);
                }
                break;
            case 25:
                SceneManager.LoadScene(3);
                break;
            default:                
                break;
        }    
    }

    public void completeObjective()
    {
        objectiveComplete.Play();
        GlobalData.playerLevel += 1;
        objBtn.GetComponent<Button>().interactable = false;
        MenuManager.SaveGame(4);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeManager : MonoBehaviour
{
    
    public GameObject leverRecipe;
    public GameObject sprocketRecipe;
    public GameObject widgetRecipe;
    public GameObject gidgetRecipe;
    public GameObject doodadRecipe;
    public GameObject whizbangRecipe;
    public GameObject whatzitRecipe;
    public GameObject thingamajigRecipe;
    public GameObject gizmoRecipe;
    public GameObject gadgetRecipe;

    // Start is called before the first frame update
    private void Start()
    {
        leverRecipe.SetActive(false);
        sprocketRecipe.SetActive(false);
        widgetRecipe.SetActive(false);
        gidgetRecipe.SetActive(false);
        doodadRecipe.SetActive(false);
        whizbangRecipe.SetActive(false);
        whatzitRecipe.SetActive(false);
        thingamajigRecipe.SetActive(false);
        gizmoRecipe.SetActive(false);
        gadgetRecipe.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalData.springCount >= 0)
        {
            sprocketRecipe.SetActive(true);
        }

        if (GlobalData.gearCount >= 0)
        {
            leverRecipe.SetActive(true);
        }

        if (GlobalData.leverCount >= 0)
        {
            widgetRecipe.SetActive(true);
        }

        if(GlobalData.widgetCount >= 0)
        {
            gidgetRecipe.SetActive(true);
        }

        if (GlobalData.gidgetCount >= 0)
        {
            doodadRecipe.SetActive(true);
        }

        if (GlobalData.doodadCount >= 0)
        {
            whizbangRecipe.SetActive(true);
        }

        if (GlobalData.whizbangCount >= 0)
        {
            whatzitRecipe.SetActive(true);
        }

        if (GlobalData.whatzitCount >= 0)
        {
            thingamajigRecipe.SetActive(true);
        }

        if (GlobalData.thingamajigCount >= 0)
        {
            gizmoRecipe.SetActive(true);
        }

        if (GlobalData.gizmoCount >= 0)
        {
            gadgetRecipe.SetActive(true);
        }

    }
}

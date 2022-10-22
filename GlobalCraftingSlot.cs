using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCraftingSlot : MonoBehaviour
{
    public GameObject craftingSlot1;
    public static bool isSlot1Open = true;
    public static string inSlot1 = "none";
    public GameObject craftingSlot2;
    public static bool isSlot2Open = false;
    public static string inSlot2 = "none";
    public GameObject craftingSlot3;
    public static bool isSlot3Open = false;
    public static string inSlot3 = "none";

    
    public Sprite newSprite;   


    private void Update()
    {

        if (isSlot1Open)
        {
            craftingSlot1.GetComponent<Image>().sprite = newSprite;
        }

        if (isSlot2Open)
        {
            craftingSlot2.GetComponent<Image>().sprite = newSprite;
        }

        if (isSlot3Open)
        {
            craftingSlot3.GetComponent<Image>().sprite = newSprite;
        }
    }

}

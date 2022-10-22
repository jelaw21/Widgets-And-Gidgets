using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryClick : MonoBehaviour
{
    public GameObject craft1;
    public GameObject craft2;
    public GameObject craft3;


    public GameObject warningPanel;
    public GameObject warningMessage;

    public Sprite newSprite;

    public static InventoryClick ClearIt;

    public AudioSource playInvClickSound;
    public AudioSource playClearSound;

    public void Start()
    {
        ClearIt = this;
    }

    public void clickedInventoryItem(GameObject inventorySlotImage)

    {
        playInvClickSound.Play();

        if(craftItem.checkMats(inventorySlotImage.name, 0))
        {
            if (GlobalCraftingSlot.isSlot1Open)
            {
            
                craft1.GetComponent<Image>().sprite = inventorySlotImage.GetComponent<Image>().sprite;
                GlobalCraftingSlot.inSlot1 = inventorySlotImage.name;
                GlobalCraftingSlot.isSlot1Open = false;
                GlobalCraftingSlot.isSlot2Open = true;
            }
            else if (GlobalCraftingSlot.isSlot2Open)
            {
                craft2.GetComponent<Image>().sprite = inventorySlotImage.GetComponent<Image>().sprite;
                GlobalCraftingSlot.inSlot2 = inventorySlotImage.name;
                GlobalCraftingSlot.isSlot2Open = false;
                GlobalCraftingSlot.isSlot3Open = true;
            }
            else if(GlobalCraftingSlot.isSlot3Open)
            {
                craft3.GetComponent<Image>().sprite = inventorySlotImage.GetComponent<Image>().sprite;
                GlobalCraftingSlot.inSlot3 = inventorySlotImage.name;
                GlobalCraftingSlot.isSlot3Open = false;
            }
            else
            {
                clearCraft();
            }
        }
    }

    public void clearCraft()
    {
        playClearSound.Play();
        craft1.GetComponent<Image>().sprite = newSprite;
        craft2.GetComponent<Image>().sprite = newSprite;
        craft3.GetComponent<Image>().sprite = newSprite;
        GlobalCraftingSlot.isSlot1Open = true;
        GlobalCraftingSlot.isSlot2Open = false;
        GlobalCraftingSlot.isSlot3Open = false;
        GlobalCraftingSlot.inSlot1 = "none";
        GlobalCraftingSlot.inSlot2 = "none";
        GlobalCraftingSlot.inSlot3 = "none";
    }


}

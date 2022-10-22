using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class SteamAchieves : MonoBehaviour
{    
    private void Update()
    {
        if (SteamManager.Initialized)
        {

            //LEVEL ACHIEVES

            switch (GlobalData.playerLevel)
            {
                case 5:
                    Steamworks.SteamUserStats.SetAchievement("ACHIEVE_LEVEL_5");
                    SteamUserStats.StoreStats();
                    break;
                case 10:
                    Steamworks.SteamUserStats.SetAchievement("ACHIEVE_LEVEL_10");
                    SteamUserStats.StoreStats();
                    break;
                case 15:
                    Steamworks.SteamUserStats.SetAchievement("ACHIEVE_LEVEL_15");
                    SteamUserStats.StoreStats();
                    break;
                case 20:
                    Steamworks.SteamUserStats.SetAchievement("ACHIEVE_LEVEL_20");
                    SteamUserStats.StoreStats();
                    break;
                case 25:
                    Steamworks.SteamUserStats.SetAchievement("GAME_WIN");
                    SteamUserStats.StoreStats();
                    break;
                default:
                    break;
            }

            //Widget Achieves  5  100  250  1000  2000  5000
            if (GlobalData.maxWidgetCount >= 5000)
            {
                Steamworks.SteamUserStats.SetAchievement("WIDGET_5000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWidgetCount >= 2500)
            {
                Steamworks.SteamUserStats.SetAchievement("WIDGET_2000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWidgetCount >= 1000)
            {
                Steamworks.SteamUserStats.SetAchievement("WIDGET_1000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWidgetCount >= 250)
            {
                Steamworks.SteamUserStats.SetAchievement("WIDGET_250");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWidgetCount >= 100)
            {
                Steamworks.SteamUserStats.SetAchievement("WIDGET_100");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWidgetCount >= 5)
            {
                Steamworks.SteamUserStats.SetAchievement("WIDGET_5");
                SteamUserStats.StoreStats();
            }
            else 
            {
                
            }

            if (GlobalData.maxGidgetCount >= 5000)
            {
                Steamworks.SteamUserStats.SetAchievement("GIDGET_5000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGidgetCount >= 2500)
            {
                Steamworks.SteamUserStats.SetAchievement("GIDGET_2000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGidgetCount >= 1000)
            {
                Steamworks.SteamUserStats.SetAchievement("GIDGET_1000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGidgetCount >= 250)
            {
                Steamworks.SteamUserStats.SetAchievement("GIDGET_250");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGidgetCount >= 100)
            {
                Steamworks.SteamUserStats.SetAchievement("GIDGET_100");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGidgetCount >= 5)
            {
                Steamworks.SteamUserStats.SetAchievement("GIDGET_5");
                SteamUserStats.StoreStats();
            }
            else
            {

            }

            if (GlobalData.maxDoodadCount >= 5000)
            {
                Steamworks.SteamUserStats.SetAchievement("DOODAD_5000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxDoodadCount >= 2500)
            {
                Steamworks.SteamUserStats.SetAchievement("DOODAD_2000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxDoodadCount >= 1000)
            {
                Steamworks.SteamUserStats.SetAchievement("DOODAD_1000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxDoodadCount >= 250)
            {
                Steamworks.SteamUserStats.SetAchievement("DOODAD_250");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxDoodadCount >= 100)
            {
                Steamworks.SteamUserStats.SetAchievement("DOODAD_100");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxDoodadCount >= 5)
            {
                Steamworks.SteamUserStats.SetAchievement("DOODAD_5");
                SteamUserStats.StoreStats();
            }
            else
            {

            }

            if (GlobalData.maxWhizbangCount >= 5000)
            {
                Steamworks.SteamUserStats.SetAchievement("WHIZBANG_5000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWhizbangCount >= 2500)
            {
                Steamworks.SteamUserStats.SetAchievement("WHIZBANG_2000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWhizbangCount >= 1000)
            {
                Steamworks.SteamUserStats.SetAchievement("WHIZBANG_1000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWhizbangCount >= 250)
            {
                Steamworks.SteamUserStats.SetAchievement("WHIZBANG_250");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWhizbangCount >= 100)
            {
                Steamworks.SteamUserStats.SetAchievement("WHIZBANG_100");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWhizbangCount >= 5)
            {
                Steamworks.SteamUserStats.SetAchievement("WHIZBANG_5");
                SteamUserStats.StoreStats();
            }
            else
            {

            }

            if (GlobalData.maxWhatzitCount >= 5000)
            {
                Steamworks.SteamUserStats.SetAchievement("WHATZIT_5000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWhatzitCount >= 2500)
            {
                Steamworks.SteamUserStats.SetAchievement("WHATZIT_2000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWhatzitCount >= 1000)
            {
                Steamworks.SteamUserStats.SetAchievement("WHATZIT_1000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWhatzitCount >= 250)
            {
                Steamworks.SteamUserStats.SetAchievement("WHATZIT_250");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWhatzitCount >= 100)
            {
                Steamworks.SteamUserStats.SetAchievement("WHATZIT_100");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxWhatzitCount >= 5)
            {
                Steamworks.SteamUserStats.SetAchievement("WHATZIT_5");
                SteamUserStats.StoreStats();
            }
            else
            {

            }

            if (GlobalData.maxThingamajigCount >= 5000)
            {
                Steamworks.SteamUserStats.SetAchievement("THINGAMAJIG_5000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxThingamajigCount >= 2500)
            {
                Steamworks.SteamUserStats.SetAchievement("THINGAMAJIG_2000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxThingamajigCount >= 1000)
            {
                Steamworks.SteamUserStats.SetAchievement("THINGAMAJIG_1000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxThingamajigCount >= 250)
            {
                Steamworks.SteamUserStats.SetAchievement("THINGAMAJIG_250");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxThingamajigCount >= 100)
            {
                Steamworks.SteamUserStats.SetAchievement("THINGAMAJIG_100");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxThingamajigCount >= 5)
            {
                Steamworks.SteamUserStats.SetAchievement("THINGAMAJIG_5");
                SteamUserStats.StoreStats();
            }
            else
            {

            }

            if (GlobalData.maxGizmoCount >= 5000)
            {
                Steamworks.SteamUserStats.SetAchievement("GIZMO_5000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGizmoCount >= 2500)
            {
                Steamworks.SteamUserStats.SetAchievement("GIZMO_2000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGizmoCount >= 1000)
            {
                Steamworks.SteamUserStats.SetAchievement("GIZMO_1000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGizmoCount >= 250)
            {
                Steamworks.SteamUserStats.SetAchievement("GIZMO_250");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGizmoCount >= 100)
            {
                Steamworks.SteamUserStats.SetAchievement("GIZMO_100");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGizmoCount >= 5)
            {
                Steamworks.SteamUserStats.SetAchievement("GIZMO_5");
                SteamUserStats.StoreStats();
            }
            else
            {

            }

            if (GlobalData.maxGadgetCount >= 5000)
            {
                Steamworks.SteamUserStats.SetAchievement("GADGET_5000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGadgetCount >= 2500)
            {
                Steamworks.SteamUserStats.SetAchievement("GADGET_2000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGadgetCount >= 1000)
            {
                Steamworks.SteamUserStats.SetAchievement("GADGET_1000");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGadgetCount >= 250)
            {
                Steamworks.SteamUserStats.SetAchievement("GADGET_250");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGadgetCount >= 100)
            {
                Steamworks.SteamUserStats.SetAchievement("GADGET_100");
                SteamUserStats.StoreStats();
            }
            else if (GlobalData.maxGadgetCount >= 5)
            {
                Steamworks.SteamUserStats.SetAchievement("GADGET_5");
                SteamUserStats.StoreStats();
            }
            else
            {

            }

        }

    }


}

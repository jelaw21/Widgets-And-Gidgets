using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopper : MonoBehaviour
{
    public static int[] partCosts = { 8, 6, 6, 6 };
    public static string[] partItems = { "spring", "gear", "sprocket", "lever" };
    public bool machineOn = false;

    public AudioSource stopAll;


    public void StopIt()
    {
        stopAll.Play();
        GlobalData.screncherIsOn = false;
        GlobalData.whomperIsOn = false;
        GlobalData.sprockonaterIsOn = false;
        GlobalData.crankyIsOn = false;
        GlobalData.fidgitronIsOn = false;
        GlobalData.supertsxIsOn = false;
        GlobalData.hypergulatorIsOn = false;
        GlobalData.phasiomaticIsOn = false;
        GlobalData.catatranslyticIsOn = false;
        GlobalData.crosspneumaticclunkerIsOn = false;
        GlobalData.magnetoconverterIsOn = false;
        GlobalData.photooscilatorIsOn = false;
    }
}

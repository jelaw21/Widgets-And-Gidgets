using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stayputer: MonoBehaviour
{
    public static int[] partCosts = {6, 4, 2, 2 };
    public static string[] partItems = { "rod", "plate", "spring", "gear" };
    public int sinceRepairs;
    public int tilRepairs;
    public int level;

    public bool machineOn = false;

}

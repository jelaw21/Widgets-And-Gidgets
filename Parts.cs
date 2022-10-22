using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parts : MonoBehaviour
{
    public static Parts part;

    //Part Icons
    public Sprite rod;
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
    public Sprite invalid;

    public void Start()
    {
        part = this;
    }

    public Sprite lookup(string part)
    {
        switch (part)
        {
            case "rod":
                return rod;
            case "plate":
                return plate;
            case "spring":
                return spring;
            case "gear":
                return gear;
            case "lever":
                return lever;
            case "sprocket":
                return sprocket;
            case "widget":
                return widget;
            case "gidget":
                return gidget;
            case "doodad":
                return doodad;
            case "whizbang":
                return whizbang;
            case "whatzit":
                return whatzit;
            case "thingamajig":
                return thingamajig;
            case "gizmo":
                return gizmo;
            case "gadget":
                return gadget;
            default:
                return invalid;
        }
    }
}

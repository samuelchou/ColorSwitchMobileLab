using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorSet
{
    public static Color purple = new Color(140f / 255, 20f / 255, 251f / 255);
    public static Color yellow = new Color(246f / 255, 224f / 255, 13f / 255);
    public static Color red = new Color(245f / 255, 0, 128f / 255);
    public static Color teal = new Color(79f / 255, 226f / 255, 242f / 255);

    public static Color[] colors = new Color[] {
        purple, yellow, red, teal
    };

    public static Color GetColorByName(string name)
    {
        switch (name)
        {
            case "Purple":
                return purple;
            case "Yellow":
                return yellow;
            case "Red":
                return red;
            case "Teal":
                return teal;
            default:
                return Color.white;
        }
    }
}
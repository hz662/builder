using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class subtitleFW : MonoBehaviour
{
    public TMP_Text subtitle;

    public void NewCase()
    {
        subtitle.text = "And now we will place the cooler and then the powersupply";
    }

    public void Cooler()
    {
        subtitle.text = "For this build we will place the water cooler on the top while keeping the tubes facing the right side, do check if thermal paste is added and also this build only requires a slide in for more info check your manual";
    }

    public void PowerSupply()
    {
        subtitle.text = "As the cables are already set up and connected to the power supply, just doc the power supply on the bottom side of the case";
    }

}

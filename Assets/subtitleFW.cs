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
        subtitle.text = "First thing first, you must open the cover of your computer case and place it on a stable surface.";
    }

    public void Cooler()
    {
        subtitle.text = "Then place the mother board in a proper way inside your case and make sure that the motherboard back ports placed properly, and don't for get to tightly nail your motherboard.";
    }

    public void PowerSupply()
    {
        subtitle.text = "To set the CPU, you need to open the socket buffer using the release lever, then insert the CPU carefully by making the arrow on the corner of the CPU facing the arrow beside the CPU socket, don't panic when the socket buffer pops out.";
    }

}

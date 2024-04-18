using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Subtitleha : MonoBehaviour
{
    public TMP_Text subtitle;
  
      public void ssd()
    {
        subtitle.text = "First thing first, you must open the cover of your computer case and place it on a stable surface.";
    }
    
    
    
    public void gpu()
    {
        subtitle.text = "Then place the mother board in a proper way inside your case and make sure that the motherboard back ports placed properly, and don't for get to tightly nail your motherboard.";
    }    
}

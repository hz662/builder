using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Subtitle : MonoBehaviour
{
    public TMP_Text subtitle;
  
      public void Case()
    {
        subtitle.text = "First thing first, you must open the cover of your computer case and place it on a stable surface.";
    }
    
    
    
    public void MotherBoard()
    {
        subtitle.text = "Then place the mother board in a proper way inside your case and make sure that the motherboard back ports placed properly, and don't for get to tightly nail your motherboard.";
    }    

    public void CPU()
    {
    subtitle.text ="To set the CPU, you need to open the socket buffer using the release lever, then insert the CPU carefully by making the arrow on the corner of the CPU facing the arrow beside the CPU socket, don't panic when the socket buffer pops out.";
    }

        public void RAM()
    {
    subtitle.text ="Finally, open the ram slots then insert the RAM sticks carefully until you hear a click sound.";
    }
}

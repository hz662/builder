using System.Collections;
using UnityEngine;

public class RamReplacement : MonoBehaviour
{
    public Animator oldRamAnimator; // Assign in the Inspector
    public Animator newRamAnimator; // Assign in the Inspector
    public float delayBetweenAnimations = 1.0f; // Delay between animations, adjust as needed

    // Update is called once per frame
    void Update()
    {
        // Check if the 'R' key is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Start the RAM replacement process
            StartCoroutine(RamReplacementSequence());
        }
    }

    IEnumerator RamReplacementSequence()
    {
        // Play the old RAM removal animation
        oldRamAnimator.Play("RAM Out");

        // Wait for the removal animation to finish plus any additional delay
        yield return new WaitForSeconds(oldRamAnimator.GetCurrentAnimatorStateInfo(0).length + delayBetweenAnimations);

        // Play the new RAM insert animation
        newRamAnimator.Play("New RAM");

        // If needed, you can wait for the insert animation to finish before continuing
        // yield return new WaitForSeconds(newRamAnimator.GetCurrentAnimatorStateInfo(0).length);
    }
}


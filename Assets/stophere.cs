using UnityEngine;

public class FinalStageScript : StateMachineBehaviour
{
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // This method is called when the animation state exits
        
        // Stop the animator to freeze the object's position at the end of the animation
        animator.speed = 0f;

        // Optionally, set the object's position to match the final frame of the animation
        animator.transform.position = animator.transform.position;
    }
}

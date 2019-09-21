using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehaviour : StateMachineBehaviour
{
 
  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
  {


  }

  public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
  {
    Blink(animator);
  }

  private void Blink(Animator animator)
  {
    if (animator.GetBool("Blink") == false)
    {
      int blinkChance = Random.Range(0, 3);

      if (blinkChance == 2)
      {
        animator.SetBool("Blink", true);
      }
    }
    else
    {
      animator.SetBool("Blink", false);
    }
  }
}

using UnityEngine;
using System. Collections;

public static class AnimatorExtensions  ///* MonoBehaviour
{
    public static IEnumerator WaitForCurrentAnimation(this Animator animator, int layer = 0)
    {
        yield return null;
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(layer).length);
        ///*while (animator. IsInTransition(layer))
        ///*{
        ///  
        ///*}
        ///* AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(layer);
        ///*while (! animator. IsInTransition(layer) && stateInfo.normalizedTime < 1f)
        ///*{
            ///*yield return null;
            ///* stateInfo = animator.GetCurrentAnimatorStateInfo(layer);
        ///*}
    }
}

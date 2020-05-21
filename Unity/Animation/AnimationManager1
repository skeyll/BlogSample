using UnityEngine;
using System.Collections;

public class AnimationManager1 : MonoBehaviour{
  [SerializeField] Animator animator; 
  bool isContinuous;
　//Call this method at an inputing key.
　public void PlayAnimation(int state) {
      if(isContinuous){
      //The way to overwrite the input by new one.
      StopCoroutine("InitializeParameter");
      animator.SetInteger("Command", 0);

      //The way to stop input.
      //return;
      }
     
     isContinuous = true;
     animator.SetInteger("Command", state);
     //Need to call coroutine by string for stopping this.
     //Or the coroutine add IEnumerator variable and call the process by it.
     //The method way(like XXX()) creates new coroutine every time it's invoked.
　　　StartCoroutine("InitializeParameter");
    }

　IEnumerator InitializeParameter(){ 
　　 //Need a flame for switching animation.
    //Without this the above method can't switch a state.
    yield return null;

　　 animator.SetInteger("Command", 0);
     //Switch the flag after this process has finished.
     isCoutinuous = false;
    }
}

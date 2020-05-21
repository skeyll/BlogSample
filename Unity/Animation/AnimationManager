using UnityEngine;
using System.Collections; //Need this for coroutine.

public class AnimationManager : MonoBehaviour{
　 //Set a model's "Animation Controller" on Inspecter.
  [SerializeField] Animator animator; 

　//Call this method at an inputing key.
　public void PlayAnimation(int state) {
　　　//Create "Command" in Parameters and change each animation by its value.
     animator.SetInteger("Command", state);
　　　StartCoroutine(InitializeParameter());
    }

　IEnumerator InitializeParameter(){ 
　　 //Need a flame for switching animation.
    //Without this the above method can't switch a state.
    yield return null;

　　 animator.SetInteger("Command", 0);
    }
}

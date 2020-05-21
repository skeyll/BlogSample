using System.Collections;
using UnityEngine;

public class ThreeWayTap : MonoBehaviour {

    public int touchType { get; private set; }
    //Can change the interval with this.
    float inputLimit = 0.3f;

   //Set to PointerDown Event / or ues EventTrigger method.
    public void PressButton() {
        if (touchType <= 0) {
            StartCoroutine(CountWaitTime());
            touchType = 1;
        } else {
            touchType = 2;
        }
    }
   //Set to PointerUp Event.
    public void ReleaseButton() {
        if (touchType == 1) {
            touchType = 3;
        }
    }

    IEnumerator CountWaitTime() {
        
        yield return new WaitForSeconds(inputLimit);

        switch (touchType){
            case 1:
                Debug.Log("LongTap");
                break;
            case 2:
                //Tap, Lift, Tap again
                Debug.Log("DoubleTap");
                break;
            case 3:
                //Tap, Lift
                Debug.Log("SingleTap");
                break;
        }
        //Initialize
        touchType = 0;
    }
}

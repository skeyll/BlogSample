using UnityEngine;

public class SingleClick : MonoBehaviour{
    void Update(){
        if (Input.GetMouseButton(0)){
            Debug.Log("Punch");
        }
    }
}

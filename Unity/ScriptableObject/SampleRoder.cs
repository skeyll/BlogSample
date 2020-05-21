using System.Collections.Generic;
using UnityEngine;

public class SampleRoder : MonoBehaviour {
    StoryData storyData;
    StoryScene storyScene;
    int loadLine, storynumber;

    void Start() {
        storynumber = 0;
        //Get an asset file from resources.
        //Set the "storynumber" on other scene.
        storyData = Resources.Load("Story" + storynumber.ToString() ) as StoryData;
        LoadNextPart(); 
    }

    //Subscribe to button click event.
    public void LoadNextPart() {

        if (loadLine < storyData.StoryScript.Count) {
            //At first, load some data from array.
            storyScene = storyData.StoryScript[loadLine];
            //Do stuff here
            
            Debug.Log(storyScene.SceneText);

            loadLine++;
        } else {
            DisplayResult();
        }
    }

    void DisplayResult() {
        Debug.Log("CLEAR!");
    }
}

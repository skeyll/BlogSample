using System.Collections;
using UnityEngine;
using System.IO;
using System;
public class ScreenshotGenerater1 : MonoBehaviour {
    [SerializeField] Vector2Int imageSize = new Vector2Int (500, 250);
    [SerializeField] GameObject screenshotCanvas;

    //Set to ButtonEvent.
	public void LoadTexsture() {
        //Change Canvas active.
        screenshotCanvas.SetActive(true);
        StartCoroutine("TakeScreenshot");
    }

    IEnumerator TakeScreenshot() {
        //Wait until rendered.
        yield return new WaitForEndOfFrame();

        //Create a new texture with the width and height of the screen.
        Texture2D texture = new Texture2D(imageSize.x, imageSize.y, TextureFormat.RGB24, false);

        //case: we take a pic on the center of screen
        //If you take a ScreenShot of the resolution size, you can use the following code.
        //texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
        float imagePosX = (Screen.width - imageSize.x) / 2;
        float imagePosY = (Screen.height - imageSize.y) / 2;

        texture.ReadPixels(new Rect(imagePosX, imagePosY, imageSize.x, imageSize.y), 0, 0);
        texture.Apply();
        //Can select file extention.
        byte[] jpgFile = texture.EncodeToJPG();
        //Release explicitly.     
        DestroyImmediate(texture);
        //Change Canvas active.
        screenshotCanvas.SetActive(false);
        
        //Use the date in the file name,
        //as it will be overwritten if the same file is present.
        string savePath = "/" + DateTime.Now.ToString("MMdd_hhmmss") + ".jpg";

        File.WriteAllBytes(Application.dataPath + savePath, jpgFile);
    }
}

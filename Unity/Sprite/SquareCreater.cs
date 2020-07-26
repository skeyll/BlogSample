using UnityEngine;

public class SquareCreater : MonoBehaviour{
    [SerializeField] SpriteRenderer testSprite;
    void Start() {
        CreateNewTexture(9);
    }
    void CreateNewTexture(int commandAmount){
        //Pure rectangle
        int width = 65 * commandAmount;
        int row = 1 + commandAmount / 7;
        int height = 65 * row;
        //Create rextangle texture
        Texture2D texture2D = new Texture2D (width, height);
        //Rectangle pixels
        int pixelAmount = width * height;
        //Amount of colored pixels in a low 
        int clearBaundary = 6 - (commandAmount % 6);
        //Create array for color
        Color[] changedPixels = new Color[pixelAmount];
        //input color
        for (int i = 0; i < pixelAmount; i++) {
            if(i >= pixelAmount / row){
                changedPixels.SetValue(Color.white, i);
            }else if (width / clearBaundary <= i % width){
                changedPixels.SetValue(Color.clear, i);
            }else{
                changedPixels.SetValue(Color.white, i);
            }
        }
        //Create texture with pixels
        Texture2D newTexture = new Texture2D (texture2D.width, texture2D.height, TextureFormat.RGBA32, false);
        newTexture.filterMode = FilterMode.Point;
        newTexture.SetPixels (changedPixels);
        newTexture.Apply();
        //Create sprite of texture
        Sprite sprite = Sprite.Create(newTexture, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));
        testSprite.sprite = sprite;
    }
}

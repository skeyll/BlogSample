using UnityEngine;

public class TriangleCreater : MonoBehaviour{
    [SerializeField] SpriteRenderer testSprite;
    void Start() {
        CreateTriangle();
    }    
    void CreateTriangle(){
        //Pure rectangle
        int width = 65;
        int height = 65;
        //Create rextangle texture
        Texture2D texture2D = new Texture2D (width, height);
        //Rectangle pixels
        int pixelAmount = width * height;
        //The part of clear
        int heightCount = 0;
        //Create array for color
        Color[] changedPixels = new Color[pixelAmount];
        bool putColor = false;
        //input color
        for (int i = 0; i < pixelAmount; i++) {
            if((height * heightCount) == i){
                heightCount += 1;
                putColor = false;
            }else if((height * heightCount) - heightCount == i){
                putColor = true; 
            }
            if(putColor){
                changedPixels.SetValue(Color.white, i);
            }else{
                changedPixels.SetValue(Color.clear, i);
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

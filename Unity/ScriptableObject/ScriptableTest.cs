using UnityEngine;

public class ScriptableTest : MonoBehaviour　{
    [SerializeField] ScriptableProperty itemData;

    void Start() {
        Debug.Log("ID:" + itemData.ItemID + "/Name:" + itemData.ItemName + "/Stock:" + itemData.stock);
    }
}

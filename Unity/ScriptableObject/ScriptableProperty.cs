using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "GameData/ItemData", order = 1)]
public class ScriptableProperty : ScriptableObject {
    public enum ItemType {
        Fish,
        Meat,
        Mushroom
    }
    public enum ItemRarity {
        Common,
        Rare,
        Epic
    }

    [SerializeField] ItemType _itemType;
    [SerializeField] ItemRarity _itemRarity;
    public int stock;
    int _itemID;
    public int ItemID {
        get { return _itemID; }
        private set {  _itemID = value;}
    }
    public string ItemName { get { return _itemType.ToString() + _itemRarity.ToString(); } }
    

    void SetID() {
        if (_itemType == ItemType.Fish) {
            ItemID = 101;
        } else if (_itemType == ItemType.Meat) {
            ItemID = 201;
        } else if (_itemType == ItemType.Mushroom) {
            ItemID = 301;
        }
    }
    void Start() {
        SetID();
    }
}

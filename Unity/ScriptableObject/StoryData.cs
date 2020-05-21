using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameData/CreateProt")]
public class StoryData : ScriptableObject {

    enum BGM {
        Street,
        GrassLand,
        NightPark
    }
    [SerializeField] BGM _bgm;
    public string bgm { get { return _bgm.ToString(); } }
    public List StoryScript = new List();
}

[System.Serializable]
public class StoryScene {
    enum TextRole {
        Title,
        Discription,
        Conversation
    }
    //Scene background
    enum Field {
        House,
        Street,
        Grassland
    }

    enum Model {
        David,
        Thijs
    }

    enum ModelPos {
        Right,
        Center,
        Left
    }
    public string Speaker;

    [SerializeField] TextRole _textRole;
    public int textRole { get { return (int)_textRole; } }

    [SerializeField] Model _model;
    public int ModelNumber; //Change the model image.
    public string model { get { return _model.ToString() + ModelNumber.ToString(); } }


    [SerializeField] ModelPos _modelPos; //Change the model position by if statement.
    public int modelPos { get { return (int)_modelPos; } }

    [SerializeField] Field _field;
    [SerializeField] int fieldNumber;
    public string field { get { return _field.ToString() + fieldNumber.ToString(); } }

    public string SceneText;
}

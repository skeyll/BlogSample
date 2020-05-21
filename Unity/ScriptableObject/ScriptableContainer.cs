using UnityEngine;
[CreateAssetMenu(fileName = "Data",
 menuName = "GameData/EnemyData",
order = 0)]
public class ScriptableContainer : ScriptableObject　{
 public enum EnemyType {
 Nomal,
 Boss
}

public EnemyType enemyType;
public int enemyLevel;
public bool isHuman;
public Vector3[] spawnPoints;
}

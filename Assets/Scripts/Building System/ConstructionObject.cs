using UnityEngine;
using System.Collections;


[System.Serializable]
public class ConstructionObject {

    public string constructionName;
    public int constructionID;
    public int constructionHealth;
    public int constructionPowerStorage;

    public ConstructionObject(string name, int id, int health, int powerStorage)
    {
        constructionName = name;
        constructionID = id;
        constructionHealth = health;
        constructionPowerStorage = powerStorage;

    }

    public ConstructionObject()
    {

    }
}

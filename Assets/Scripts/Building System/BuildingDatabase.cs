using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BuildingDatabase : MonoBehaviour {

    public List<ConstructionObject> buildings = new List<ConstructionObject>();

	// Use this for initialization
	void Start () {

        buildings.Add(new ConstructionObject("Foundation",0,1000,100));

	}
}

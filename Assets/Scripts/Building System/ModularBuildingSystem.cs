using UnityEngine;
using System.Collections;

public class ModularBuildingSystem : MonoBehaviour {

    public GameObject objectPreview;
    public GameObject theObject;
    public BuildingDatabase buildingDatabase;

    public bool jointedPlacing;
    public bool placerShowing;

	// Use this for initialization
	void Start () {
        objectPreview.SetActive(false);
        buildingDatabase = GameObject.FindGameObjectWithTag("BuildingDatabase").GetComponent<BuildingDatabase>();

	}
	
	// Update is called once per frame
	void Update () {



	}

    public void PlaceFreebuildConstruction()
    {

    }

    public void PlaceJointedConstruction()
    {

    }
}

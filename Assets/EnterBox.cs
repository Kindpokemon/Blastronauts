using UnityEngine;
using System.Collections;

public class EnterBox : MonoBehaviour {

    public StartFunctions startFunctions;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    
    public void OnMouseEnter()
    {
        startFunctions.crosshair = startFunctions.lookatCrosshair;
        Debug.Log("Lookie here");
    }

    public void OnMouseExit()
    {
        startFunctions.crosshair = startFunctions.normalCrosshair;
    }
}

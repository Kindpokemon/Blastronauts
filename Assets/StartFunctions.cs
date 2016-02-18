using UnityEngine;
using System.Collections;

public class StartFunctions : MonoBehaviour {

    public Texture2D crosshair;
    public Texture2D normalCrosshair;
    public Texture2D lookatCrosshair;
    public Rect crosshairPosition;
    public static bool crosshairOn = true;
    public ItemInteract itemInteract;

	// Use this for initialization
	void Start () {

        crosshairPosition = new Rect((Screen.width - crosshair.width) / 2, (Screen.height - crosshair.height) / 2, crosshair.width, crosshair.height);
        crosshair = normalCrosshair;
    }
	
	// Update is called once per frame
	void Update () {
        Screen.lockCursor = true;

        if (itemInteract.isRiding)
        {
            crosshair = normalCrosshair;
        }
    }

    void OnGUI()
    {
        if(crosshairOn == true)
        {
            GUI.DrawTexture(crosshairPosition, crosshair);
        }

        
    }
}

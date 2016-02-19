using UnityEngine;
using System.Collections;

public class ItemInteract : MonoBehaviour {

    RaycastHit hit;
    public StartFunctions startFunctions;
    public bool isRiding;
    public GameObject riding;

    void Start()
    {
        
    }

    void Update()
    {
        if (!isRiding)
        {
            Debug.DrawRay(transform.position, transform.forward * 2f, Color.red, 2f);
            if (Physics.Raycast(transform.position, transform.forward * 2f, out hit, 2f))
            {
                Debug.Log("Whaddabing");
                Debug.Log(hit.transform.gameObject);
                if (hit.transform.gameObject.tag == "Mount")
                {
                    startFunctions.crosshair = startFunctions.lookatCrosshair;
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        hit.transform.GetComponent<VehicleInfo>().RideMe(gameObject.transform.parent.gameObject);
                    }
                }
            }
            else
            {
                startFunctions.crosshair = startFunctions.normalCrosshair;
            }
        }
        else
        {
            if (isRiding && Input.GetKeyDown(KeyCode.E))
            {
                riding.GetComponent<VehicleInfo>().Dismount(gameObject.transform.parent.gameObject);
            }
        }
    }
}

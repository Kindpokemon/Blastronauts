using UnityEngine;
using System.Collections;

public class VehicleInfo : MonoBehaviour {

    public Quaternion playerRotation;
    public Vector3 playerPosition;
    public GameObject mount;
    public GameObject thePlayer;
    public enum VehicleType
    {
        Hover,
        Land,
        Water,
        Space
    }
    public VehicleType vehicleType;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RideMe(GameObject player)
    {
        player.transform.GetChild(0).GetComponent<ItemInteract>().riding = gameObject;
        player.transform.GetChild(0).GetComponent<ItemInteract>().isRiding = true;
        player.transform.SetParent(mount.transform);
        player.GetComponent<CharacterController>().enabled = false;
        player.transform.localRotation = playerRotation;
        player.transform.localPosition = playerPosition;
        if (vehicleType == VehicleType.Hover)
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.GetComponent<CharacterController>().enabled = true;
            gameObject.GetComponent<HovershipController>().enabled = true;
        }
    }

    public void Dismount(GameObject player)
    {

        player.transform.position = player.transform.position + new Vector3(0, 5, 0);
        player.transform.GetChild(0).GetComponent<ItemInteract>().riding = null;
        player.transform.GetChild(0).GetComponent<ItemInteract>().isRiding = false;
        player.transform.SetParent(null);
        player.GetComponent<CharacterController>().enabled = true;
        if (vehicleType == VehicleType.Hover)
        {
            gameObject.GetComponent<CharacterController>().enabled = false;
            gameObject.GetComponent<HovershipController>().enabled = false;
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}

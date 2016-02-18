using UnityEngine;
using System.Collections;

public class AttachmentPoint : MonoBehaviour {

    public int sideNumber;
    public bool sideAttach;
    public bool topAttach;
    public bool sideEnabled;
    public bool topEnabled;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(transform.childCount > 0)
        {
            for(int i = 0; i < transform.childCount; i++)
            {
                if(transform.GetChild(i).tag == "SideAttachment" && sideEnabled == true)
                {
                    sideAttach = true;
                } else
                {
                    sideAttach = false;
                }
                if (transform.GetChild(i).tag == "TopAttachment" && topEnabled == true)
                {
                    topAttach = true;
                } else
                {
                    topAttach = false;
                }


            }
        }
	}
}

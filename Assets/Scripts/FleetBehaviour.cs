using UnityEngine;
using System.Collections;

public class FleetBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void MoveShips()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i);
        }
    }
}

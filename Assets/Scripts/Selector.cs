using UnityEngine;
using System.Collections;

public class Selector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GetComponent<MeshRenderer>().material.GetFloat("_Outline") > 0)
            {
                GetComponent<MeshRenderer>().material.SetFloat("_Outline", 0.0f);
            } else
            {
                GetComponent<MeshRenderer>().material.SetFloat("_Outline", 0.01f);
            }
        }
	}
}

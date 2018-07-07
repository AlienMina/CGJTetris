using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {
    public tetrisMove tetris;
    public GameObject water;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}
    private void FixedUpdate()
    {
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, tetris.topCube + 10, this.gameObject.transform.position.z);
        if (water.transform.position.y < tetris.topCube - 5)
        {
            water.transform.position = new Vector3(water.transform.position.x, tetris.topCube - 5, water.transform.position.z);
        }
    }
}

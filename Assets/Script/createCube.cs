using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCube : MonoBehaviour {

    public playerMove playermove;//从中获取角色面向

    int face;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))//如果按下了生成按键
        {
            //获取角色的面向
            face = playermove.checkFace();

        }
    }
}

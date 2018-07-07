using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCube : MonoBehaviour {

    public Base spaceCube;
    public playerMove playermove;//从中获取角色面向
    public int cubeType=0;//生成的方块的类型，为了测试这里一直是0
    int face;


    public GameObject Instcube0;
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
            //获取角色的坐标，并且根据角色坐标计算生成方块的坐标
            Vector3 pos = this.gameObject.transform.position;
            pos.y -= 0.5f;
            float delta;
            if (face == 1)
            {
                delta = pos.x+1;
                pos.x = delta;
                
            }
            else if (face == 2)
            {
                delta = pos.z - 1;
                pos.z = delta;
            }
            else if (face == 3)
            {
                delta = pos.z + 1;
                pos.z = delta;
            }
            else if (face == 4)
            {
                delta = pos.x - 1;
                pos.x = delta;
            }
            //检测该位置是否有方块
            Debug.Log(spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y]);
            if (!spaceCube.field[(int)pos.x,(int)pos.z,(int)pos.y].isCube&&pos.x<7&&pos.z<7)
            {
                //没有的情况下，生成一个指定属性的方块，刷新数组中对应位置的状态
                GameObject.Instantiate(Instcube0, pos, new Quaternion(0,0,0,0));
                spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].isCube = true;
            }

        }
    }
}

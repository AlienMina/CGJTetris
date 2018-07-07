using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCube : MonoBehaviour {
    /// <summary>
    /// 拆方块也写在了这里
    /// </summary>
    public Base spaceCube;
    public playerMove playermove;//从中获取角色面向
    public int cubeType=0;//生成的方块的类型，为了测试这里一直是0

    Vector3 pos;
    int face;

    public float destroyTime = 3f;//拆方块需要的时间
    bool startDestroy=false;

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
            checkPlace();
            //检测该位置是否有方块
            Debug.Log(spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y]);
            if (!spaceCube.field[(int)pos.x,(int)pos.z,(int)pos.y].isCube&&pos.x<7&&pos.z<7)
            {
                //没有的情况下，生成一个指定属性的方块，刷新数组中对应位置的状态
                GameObject.Instantiate(Instcube0, pos, new Quaternion(0,0,0,0));
                spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].isCube = true;
                spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].cubeHp = (int)destroyTime*50;
            }

        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            //首先判断面前是否有方块
            checkPlace();
            //有方块的情况下，开始凿
            if (spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].isCube)
            {
                startDestroy = true;
                spaceCube.playerMoveable = false;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            startDestroy = false;
            spaceCube.playerMoveable = true;
        }

        if (startDestroy)
        {
            spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].cubeHp--;
            if(spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].cubeHp == 0)
            {
                spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].isCube = false;
                destroyCube();
            }
        }
    }

    /// <summary>
    /// 角色面向对应的位置
    /// </summary>
    void checkPlace()
    {
        //获取角色的面向
        face = playermove.checkFace();
        //获取角色的坐标，并且根据角色坐标计算生成方块的坐标
        pos = this.gameObject.transform.position;
       // pos.y -= 0.5f;
        float delta;
        if (face == 1)
        {
            delta = pos.x + 1;
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
    }

    /// <summary>
    /// 在这里进行射线检测，删除主角面前的那个方块……
    /// </summary>
    void destroyCube()
    {
        Vector3 trans=new Vector3(0,0,0);
        if (face == 1)
        {
            trans = new Vector3(1, 0, 0);
        }
        else if (face == 2)
        {
            trans = new Vector3(0, 0, -1);
        }
        else if (face == 3)
        {
            trans = new Vector3(0, 0, 1);
        }
        else if (face == 4)
        {
            trans = new Vector3(-1, 0, 0);
        }
        Ray ray = new Ray(transform.position, trans);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            // 如果射线与平面碰撞，打印碰撞物体信息  
            Debug.Log("碰撞对象: " + hit.collider.name);
            // 在场景视图中绘制射线  
            Debug.DrawLine(ray.origin, hit.point, Color.red);
            if (hit.collider.tag == "cube")
            {
                Destroy(hit.collider.gameObject);
            }
        }

    }
}

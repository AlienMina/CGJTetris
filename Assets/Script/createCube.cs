using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCube : MonoBehaviour {
    /// <summary>
    /// 拆方块也写在了这里
    /// </summary>
    public Base spaceCube;
    public playerMove playermove;//从中获取角色面向
    public int cubeType=2;//生成的方块的类型

    Vector3 pos;
    int face;

    public float destroyTime = 3f;//拆方块需要的时间
    bool startDestroy=false;

    public GameObject[] Instcube;
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
            //Debug.Log("PlayerY: " + (int)pos.y);
            if (!spaceCube.field[(int)pos.x,(int)pos.z,(int)pos.y].isCube&&pos.x<7&&pos.z<7)//如果生成位置没有方块，并且在场景范围内
            {
                int Type = (int)Random.value * (cubeType+1);
                bool find = false;
                //pos.y += 0.1f;//用于校正高度的微调变量
                //在选定的位置生成指定类型【这里是沙子】的方块
                GameObject.Instantiate(Instcube[Type], pos, new Quaternion(0,0,0,0));
                #region oldCode
                /*
                bool find = false;
                Debug.Log("pos.y:" + (int)pos.y + " float:" + pos.y);
                Debug.Log("playerPositionCubeState: " + spaceCube.field[(int)this.gameObject.transform.position.x, (int)this.gameObject.transform.position.z, (int)this.gameObject.transform.position.y].isCube);
                //寻找沙子方块的落点
                if ((int)pos.y > 0)//不是在最底层生成，需要从当前层向下查，碰到的第一个方块的上一层就是最后的落点
                {
                    if ((int)pos.y == 1)
                    {
                        if(spaceCube.field[(int)pos.x, (int)pos.z, 0].isCube)//如果第0层有方块了，那么直接在对应位置生成
                        {
                            spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].isCube = true;
                            spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].cubeHp= (int)destroyTime * 50;
                        }
                        else
                        {
                            spaceCube.field[(int)pos.x, (int)pos.z, 0].isCube = true;
                            spaceCube.field[(int)pos.x, (int)pos.z,0].cubeHp = (int)destroyTime * 50;
                        }
                    }
                    else//从2层开始
                    {
                        for (int i = (int)pos.y; i > 0; i--)
                        {
                            Debug.Log("i: " + i);
                            if (spaceCube.field[(int)pos.x, (int)pos.z, i].isCube && !find)
                            {
                                find = true;
                                spaceCube.field[(int)pos.x, (int)pos.z, (int)i + 1].isCube = true;
                                Debug.Log("found! " + pos.x + "" + pos.y + "" + i + 1);
                                spaceCube.field[(int)pos.x, (int)pos.z, (int)i + 1].cubeHp = (int)destroyTime * 50;
                                //spaceCube.field[(int)this.gameObject.transform.position.x, (int)this.gameObject.transform.position.z, (int)this.gameObject.transform.position.y].isCube = false;//自己站的一格会谜之true……

                            }
                        }
                        if (!find)//遍历一圈还没找到，就是底层了
                        {
                            Debug.Log("isGround? " + pos.x + "" + pos.y + "");
                            spaceCube.field[(int)pos.x, (int)pos.z, 0].isCube = true;
                            spaceCube.field[(int)pos.x, (int)pos.z, 0].cubeHp = (int)destroyTime * 50;
                            find = true;
                            Debug.Log("not found in loop. " + (int)pos.x + " " + (int)pos.z);
                            Debug.Log(spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].isCube);
                            Debug.Log("playerPositionCubeStateAfterLoop: " + spaceCube.field[(int)this.gameObject.transform.position.x, (int)this.gameObject.transform.position.z, (int)this.gameObject.transform.position.y].isCube);
                            //spaceCube.field[(int)this.gameObject.transform.position.x, (int)this.gameObject.transform.position.z, (int)this.gameObject.transform.position.y].isCube = false;//自己站的一格会谜之true……

                        }
                    }

                }
                else//最底层，那么直接在对应位置生成就行，因为不能再向下掉了
                {
                    Debug.Log("ground?");
                    spaceCube.field[(int)pos.x, (int)pos.z, 0].isCube = true;
                    spaceCube.field[(int)pos.x, (int)pos.z, 0].cubeHp = (int)destroyTime * 50;

                    Debug.Log((int)pos.y);
                    Debug.Log("already ground. "+spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].isCube);
                    Debug.Log(spaceCube.field[(int)pos.x, (int)pos.z, 0].isCube);
                }*/
                #endregion
                if (Type == 1)//沙子
                {
                    for (int i = (int)pos.y; i >= 0; i--)
                    {
                        //Debug.Log("pos.y: " + pos.y);
                        if (spaceCube.field[(int)pos.x, (int)pos.z, i].isCube && !find)
                        {
                            spaceCube.field[(int)pos.x, (int)pos.z, (i + 1)].isCube = true;
                            find = true;
                            //Debug.Log("findPlace: " + pos.x + " " +( i + 1) + " " + pos.z);
                            //Debug.Log("i: " + i);
                        }
                    }
                    if (!find)
                    {
                        find = true;
                        spaceCube.field[(int)pos.x, (int)pos.z, 0].isCube = true;
                        //Debug.Log("findPlaceUnder: " + pos.x + " " +0 + " " + pos.z);
                    }
                }
                else if (Type == 0)//海绵
                {
                    spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].isCube = true;
                }
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

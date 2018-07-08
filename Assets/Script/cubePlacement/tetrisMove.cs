using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tetrisMove : MonoBehaviour
{

    public Vector3Int[,,,] state =
    {
        {
            {{new Vector3Int(0,0,0),new Vector3Int(-1,0,0),new Vector3Int(0,0,-1),new Vector3Int(1,0,-1)}   ,{new Vector3Int(0,0,0),new Vector3Int(0,-1,0),new Vector3Int(0,0,-1),new Vector3Int(0,1,-1)}   ,{new Vector3Int(0,0,0),new Vector3Int(1,0,0),new Vector3Int(0,0,-1),new Vector3Int (-1,0,-1)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,1,0),new Vector3Int(0,0,-1),new Vector3Int(0,-1,-1)} },
            {{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(-1,0,0),new Vector3Int(-1,0,-1)}   ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,-1,0),new Vector3Int(0,-1,-1)}   ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(1,0,0),new Vector3Int(1,0,-1)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,1,0),new Vector3Int(0,1,-1)} },
            {{new Vector3Int(0,0,0),new Vector3Int(-1,0,0),new Vector3Int(0,0,-1),new Vector3Int(1,0,-1)}   ,{new Vector3Int(0,0,0),new Vector3Int(0,-1,0),new Vector3Int(0,0,-1),new Vector3Int(0,1,-1)}   ,{new Vector3Int(0,0,0),new Vector3Int(1,0,0),new Vector3Int(0,0,-1),new Vector3Int(-1,0,-1)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,1,0),new Vector3Int(0,0,-1),new Vector3Int(0,-1,-1)} },
            {{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(-1,0,0),new Vector3Int(-1,0,-1)}   ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,-1,0),new Vector3Int(0,-1,-1)}   ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(1,0,0),new Vector3Int(1,0,-1)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,1,0),new Vector3Int(0,1,-1)} }
        },

        {
            {{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,0,-1),new Vector3Int(1,0,-1)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,0,-1),new Vector3Int(0,1,-1)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,0,-1),new Vector3Int(-1,0,-1)}   ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,0,-1),new Vector3Int(0,-1,-1)} },
            {{new Vector3Int(0,0,0),new Vector3Int(1,0,0),new Vector3Int(-1,0,0),new Vector3Int(-1,0,-1)}   ,{new Vector3Int(0,0,0),new Vector3Int(0,1,0),new Vector3Int(0,-1,0),new Vector3Int(0,-1,-1)}   ,{new Vector3Int(0,0,0),new Vector3Int(-1,0,0),new Vector3Int(1,0,0),new Vector3Int(1,0,-1)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,-1,0),new Vector3Int(0,1,0),new Vector3Int(0,1,-1)} },
            {{new Vector3Int(0,0,0),new Vector3Int(0,0,-1),new Vector3Int(0,0,1),new Vector3Int(-1,0,1)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,0,-1),new Vector3Int(0,0,1),new Vector3Int(0,-1,1)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,0,-1),new Vector3Int(0,0,1),new Vector3Int(1,0,1)}     ,{new Vector3Int(0,0,0),new Vector3Int(0,0,-1),new Vector3Int(0,0,1),new Vector3Int(0,1,1)} },
            {{new Vector3Int(0,0,0),new Vector3Int(-1,0,0),new Vector3Int(1,0,0),new Vector3Int(1,0,1)}     ,{new Vector3Int(0,0,0),new Vector3Int(0,-1,0),new Vector3Int(0,1,0),new Vector3Int(0,1,1)}     ,{new Vector3Int(0,0,0),new Vector3Int(1,0,0),new Vector3Int(-1,0,0),new Vector3Int(-1,0,1)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,1,0),new Vector3Int(0,-1,0),new Vector3Int(0,-1,1)}
 }
        },

        {
            {{new Vector3Int(0,0,0),new Vector3Int(-1,0,0),new Vector3Int(1,0,0),new Vector3Int(0,0,-1)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,-1,0),new Vector3Int(0,1,0),new Vector3Int(0,0,-1)}    ,{new Vector3Int(0,0,0),new Vector3Int(1,0,0),new Vector3Int(-1,0,0),new Vector3Int(0,0,-1)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,1,0),new Vector3Int(0,-1,0),new Vector3Int(0,0,-1)} },
            {{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,0,-1),new Vector3Int(-1,0,0)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,0,-1),new Vector3Int(0,-1,0)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,0,-1),new Vector3Int(1,0,0)}     ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,0,-1),new Vector3Int(0,1,0)} },
            {{new Vector3Int(0,0,0),new Vector3Int(1,0,0),new Vector3Int(-1,0,0),new Vector3Int(0,0,1)}     ,{new Vector3Int(0,0,0),new Vector3Int(0,1,0),new Vector3Int(0,-1,0),new Vector3Int(0,0,1)}     ,{new Vector3Int(0,0,0),new Vector3Int(-1,0,0),new Vector3Int(1,0,0),new Vector3Int(0,0,1)}     ,{new Vector3Int(0,0,0),new Vector3Int(0,-1,0),new Vector3Int(0,1,0),new Vector3Int(0,0,1)} },
            {{new Vector3Int(0,0,0),new Vector3Int(0,0,-1),new Vector3Int(0,0,1),new Vector3Int(1,0,0)}     ,{new Vector3Int(0,0,0),new Vector3Int(0,0,-1),new Vector3Int(0,0,1),new Vector3Int(0,1,0)}     ,{new Vector3Int(0,0,0),new Vector3Int(0,0,-1),new Vector3Int(0,0,1),new Vector3Int(-1,0,0)}    ,{new Vector3Int(0,0,0),new Vector3Int(0,0,-1),new Vector3Int(0,0,1),new Vector3Int(0,-1,0)} }
        },

        {
            {{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(1,0,1),new Vector3Int(1,0,0)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,1,1),new Vector3Int(0,1,0)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(1,0,1),new Vector3Int(1,0,0)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,1,1),new Vector3Int(0,1,0)} },
            {{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(1,0,1),new Vector3Int(1,0,0)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,1,1),new Vector3Int(0,1,0)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(1,0,1),new Vector3Int(1,0,0)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,1,1),new Vector3Int(0,1,0)} },
            {{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(1,0,1),new Vector3Int(1,0,0)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,1,1),new Vector3Int(0,1,0)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(1,0,1),new Vector3Int(1,0,0)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,1,1),new Vector3Int(0,1,0)} },
            {{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(1,0,1),new Vector3Int(1,0,0)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,1,1),new Vector3Int(0,1,0)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(1,0,1),new Vector3Int(1,0,0)}  ,{new Vector3Int(0,0,0),new Vector3Int(0,0,1),new Vector3Int(0,1,1),new Vector3Int(0,1,0)} }
        }
    }
        ;//第一维度用于存储形状，第二维度、第三维度用于存储旋转状态，第四维度用于记录各个方块的位置

    public int stateNum1 = 0;//俄罗斯方块的形状编号
    public int stateNum2 = 0;//俄罗斯方块的旋转编号
    public int stateNum3 = 0;//俄罗斯方块的旋转编号
    public int stateNum4 = 0;//俄罗斯方块的位置编号
    public int topCube = 0;//最高的方块所在层数
    public int h,i,j,k,l,m,n,o;//循环变量
    public int drop,topUp;//下落量和制高点增长量
    public bool wakeUp = false , wakeDown = false;//FindTarget()和NewTOP()死循环接触装置
    public Vector3Int aimPos;//准星所在位置
    public Vector3Int dropVec;//下落补正
    public Vector3Int[] oriPos = new Vector3Int[4];//俄罗斯方块的空中位置
    public Vector3Int[] tarPos = new Vector3Int[4];//俄罗斯方块的预计落点
    public Vector3Int[] scoPos = { new Vector3Int(3,3,3), new Vector3Int(3, 3, 3), new Vector3Int(3, 3, 3), new Vector3Int(3, 3, 3) };//俄罗斯方块的斥候位置
    public Vector3[] creatPosition = new Vector3[4];
    public Vector3[] skyPosition = new Vector3[4];
    public Base touch;
    public GameObject cube;
    public GameObject[] oriCube = new GameObject[4];
    public GameObject[] opyCube = new GameObject[4];

    //Audio
    public AudioSource tetrisCubeMove;
    public AudioSource tetrisYrotate;
    public AudioSource tetrisXZrotate;
    public AudioSource tetrisDrop;

    // Use this for initialization
    void Start ()
    {
        ResetAim();
        stateNum1 = Random.Range(0, 4);
        stateNum2 = Random.Range(0, 4);
        stateNum3 = Random.Range(0, 4);
        FindOriginal();
        FindTarget();
        ShowCube();
    }
	
	// Update is called once per frame
	void Update ()
    {
        

        //,<键 旋转1
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            tetrisXZrotate.Play();
            stateNum2 = (stateNum2 + 1) % 4;
            FindOriginal();
        switch (CheckOut())//纠错
            {
                case 0:
                    break;

                case 1:
                    aimPos.x++;
                    FindOriginal();
                    break;

                case 2:
                    aimPos.x--;
                    FindOriginal();
                    break;
                
                case 3:
                    aimPos.z++;
                    FindOriginal();
                    break;

                case 4:
                    aimPos.z--;
                    FindOriginal();
                    break;
            }
            FindTarget();
            ShowCube();
        }

        //.>键 旋转2
        if (Input.GetKeyDown(KeyCode.Period))
        {
            tetrisYrotate.Play();
            stateNum3 = (stateNum3 + 1) % 4;
            FindOriginal();
            switch (CheckOut())//纠错
            {
                case 0:
                    break;

                case 1:
                    aimPos.x++;
                    FindOriginal();
                    break;

                case 2:
                    aimPos.x--;
                    FindOriginal();
                    break;

                case 3:
                    aimPos.z++;
                    FindOriginal();
                    break;

                case 4:
                    aimPos.z--;
                    FindOriginal();
                    break;
            }
            FindTarget();
            ShowCube();
        }

        //平移
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            tetrisCubeMove.Play();
            aimPos.x--;
            FindOriginal();
            if (CheckOut() != 0)
            {
                aimPos.x++;
                FindOriginal();
            }
            FindTarget();
            ShowCube();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            tetrisCubeMove.Play();
            aimPos.y--;
            FindOriginal();
            if (CheckOut() != 0)
            {
                aimPos.y++;
                FindOriginal();
            }
            FindTarget();
            ShowCube();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            tetrisCubeMove.Play();
            aimPos.x++;
            FindOriginal();
            if (CheckOut() != 0)
            {
                aimPos.x--;
                FindOriginal();
            }
            FindTarget();
            ShowCube();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            tetrisCubeMove.Play();
            aimPos.y++;
            FindOriginal();
            if (CheckOut() != 0)
            {
                aimPos.y--;
                FindOriginal();
            }
            FindTarget();
            ShowCube();
        }

        //下落
        if (Input.GetKeyDown(KeyCode.L))
        {
            tetrisDrop.Play();
            FallDown();
        }
	}

    //找空中位置
    void FindOriginal()
    {
        for (i = 0; i < 4; i++)
        {
            oriPos[i] = state[stateNum1, stateNum2, stateNum3, i] + aimPos;//为每个方块分配位置
        }
    }

    //找预计落点
    void FindTarget()
    {
        for (drop = 1; ; drop++)
        {
            dropVec.x = 0;
            dropVec.y = 0;
            dropVec.z = drop;//下落量
            for (j = 0; j < 4; j++)
            {
                scoPos[j] = oriPos[j] - dropVec;//得出斥候位置
                if(scoPos[j].z < 0)
                {
                    dropVec.z--;
                    wakeUp = true;
                    break;
                }
                if (touch.field[scoPos[j].x, scoPos[j].y, scoPos[j].z].isCube == true)//判定是否接触
                {
                    dropVec.z--;
                    wakeUp = true;
                    break;
                }
            }
            if (wakeUp == true)
            {
                for (j = 0; j < 4; j++)
                {
                    tarPos[j] = oriPos[j] - dropVec;//得出预计落点
                }
                break;
            }
        }
        wakeUp = false;
    }

    //纠错
    int CheckOut()
    {
        int cO;
        cO = 0;
        for (k=0;k<4;k++)
        {
            if (oriPos[k].x < 0)//↑出界
                cO = 1;
            if (oriPos[k].x > 6)//↓出界
                cO = 2;
            if (oriPos[k].y < 0)//←出界
                cO = 3;
            if (oriPos[k].y > 6)//→出界
                cO = 4;
        }
        return cO;
    }

    //方块下落
    void FallDown()
    {
        for(l=0;l<4;l++)
        {
            creatPosition[l].x = tarPos[l].x * 1.0f;
            creatPosition[l].y = tarPos[l].z * 1.0f;
            creatPosition[l].z = tarPos[l].y * 1.0f;
            GameObject.Instantiate(cube, creatPosition[l], new Quaternion(0, 0, 0, 0));//生成方块实体
            touch.field[tarPos[l].x, tarPos[l].y, tarPos[l].z].isCube = true;
            touch.field[tarPos[l].x, tarPos[l].y, tarPos[l].z].cubeHp = 150;
            touch.field[tarPos[l].x, tarPos[l].y, tarPos[l].z].cubeType = 1;//改变存储数据
        }

        NewHigh();
        ResetAim();
        stateNum1 = Random.Range(0, 4);
        stateNum2 = Random.Range(0, 4);
        stateNum3 = Random.Range(0, 4);
        FindOriginal();
        FindTarget();
        ShowCube();
    }

    //方块预览
    void ShowCube()
    {       
        for (h = 0; h < 4; h++)
        {
            skyPosition[h].x = oriPos[h].x * 1.0f;
            skyPosition[h].y = oriPos[h].z * 1.0f;
            skyPosition[h].z = oriPos[h].y * 1.0f;
            oriCube[h].transform.position = skyPosition[h];
            creatPosition[h].x = tarPos[h].x * 1.0f;
            creatPosition[h].y = tarPos[h].z * 1.0f;
            creatPosition[h].z = tarPos[h].y * 1.0f;
            opyCube[h].transform.position = creatPosition[h];
        }
    }

    //更新制高点
    void NewHigh()
    {
        for (topUp = 1; ; topUp++)
        {
            for(m=0;m<7;m++)
            {
                for(n=0;n<7;n++)
                {
                    if(touch.field[m,n,topCube+topUp].isCube == true)
                    {
                        wakeDown = true;
                        break;
                    }
                }
            }

            if(wakeDown == false)
            {
                topCube = topCube + topUp - 1;
                break;
            }
            else
            {
                wakeDown = false;
            }                        
        }
    }

    //校准
    void ResetAim()
    {
        aimPos.x = 3;
        aimPos.y = 3;
        aimPos.z = topCube + 6;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tetrisMove : MonoBehaviour
{

    public Vector3Int[,,,] state = new Vector3Int[4,4,4,4];//第一维度用于存储形状，第二维度、第三维度用于存储旋转状态，第四维度用于记录各个方块的位置

    public int stateNum1 = 0;//俄罗斯方块的形状编号
    public int stateNum2 = 0;//俄罗斯方块的旋转编号
    public int stateNum3 = 0;//俄罗斯方块的旋转编号
    public int stateNum4 = 0;//俄罗斯方块的位置编号
    public int topCube = 0;//最高的方块所在层数
    public int drop,i,j,k;//循环变量
    public bool wakeUp = false;//FindTarget()死循环接触装置
    public Vector3Int aimPos;//准星所在位置
    public Vector3Int dropVec;//下落补正
    public Vector3Int[] oriPos = new Vector3Int[4];//俄罗斯方块的空中位置
    public Vector3Int[] tarPos = new Vector3Int[4];//俄罗斯方块的预计落点
    public Vector3Int[] scoPos = new Vector3Int[4];//俄罗斯方块的斥候位置
    public Base touch;


    // Use this for initialization
    void Start ()
    {
        


    }
	
	// Update is called once per frame
	void Update ()
    {

        //,<键 旋转1
        if (Input.GetKeyDown(KeyCode.Comma))
        {
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
        }

        //.>键 旋转2
        if (Input.GetKeyDown(KeyCode.Period))
        {
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
        }

        //平移
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            aimPos.x--;
            FindOriginal();
            if (CheckOut() != 0)
            {
                aimPos.x++;
                FindOriginal();
            }
            FindTarget();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            aimPos.z--;
            FindOriginal();
            if (CheckOut() != 0)
            {
                aimPos.z++;
                FindOriginal();
            }
            FindTarget();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            aimPos.x++;
            FindOriginal();
            if (CheckOut() != 0)
            {
                aimPos.x--;
                FindOriginal();
            }
            FindTarget();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            aimPos.z++;
            FindOriginal();
            if (CheckOut() != 0)
            {
                aimPos.z--;
                FindOriginal();
            }
            FindTarget();
        }

        //下落
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {

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


    void TetrisShape()
    {
        stateNum1 = Random.Range(0, 4);
    }


}

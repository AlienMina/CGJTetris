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
    public int drop,i,j;
    public Vector3Int aimPos;//准星所在位置
    public Vector3Int dropVec;
    public Vector3Int[] oriPos = new Vector3Int[4];//俄罗斯方块的空中位置
    public Vector3Int[] tarPos = new Vector3Int[4];//俄罗斯方块的预计落点
    public Vector3Int[] scoPos = new Vector3Int[4];//俄罗斯方块的斥候位置

    // Use this for initialization
    void Start ()
    {
        


    }
	
	// Update is called once per frame
	void Update ()
    {
        for(i=0;i<4;i++)
        {
            oriPos[i] = state[stateNum1, stateNum2, stateNum3, i] + aimPos;
        }

        for(drop=0; ;drop++)
        {
            dropVec.x = 0;
            dropVec.y = 0;
            dropVec.z = drop;
            for (j = 0; j < 4; j++)
            {
                scoPos[j] = oriPos[j] - dropVec;
            }
        }

        if (Input.GetKeyDown(KeyCode.Comma))//,<键 旋转1
        {
            stateNum2 = (stateNum2 + 1) % 4; 
        }
        if (Input.GetKeyDown(KeyCode.Period))//.>键 旋转2
        {
            stateNum3 = (stateNum3 + 1) % 4;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            aimPos.z++;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            aimPos.x--;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            aimPos.z--;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            aimPos.x++;
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {

        }
	}

    void TetrisShape()
    {
        stateNum1 = Random.Range(0, 4);
        switch(stateNum1)
        {
            case 0 :
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }


}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{

    public struct spaceCube
    {
        public bool isCube;
        public int cubeType;
        public int cubeHp;
    };

    public static int fieldX=7, fieldY=1000, fieldZ=7;

    public spaceCube[,,] field=new spaceCube[fieldX,fieldZ,fieldY];

    public bool playerMoveable = true;//这个是在拆方块的时候禁止角色移动的

	// Use this for initialization
	void Start ()
    {
        //初始化存储状态
        for (int i = 0; i < fieldX; i++)
        {
            for (int j = 0; j < fieldZ; j++)
            {
                for (int k = 0; k < fieldY; k++)
                {
                    field[i,j,k]= new spaceCube();
                    field[i, j, k].isCube = false;//无方块
                    field[i, j, k].cubeType = 0;
                    field[i, j, k].cubeHp = 0;
                }
            }
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

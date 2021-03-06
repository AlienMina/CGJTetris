﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    public Base spaceCube;
    Vector3 pos;
    float x;
    float z;
    float y;

    AudioSource step;

	// Use this for initialization
	void Start () {
        step = this.gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //需要预留面前方块有东西的情况，如果撞上了应该是爬上去
    private void FixedUpdate()
    {
        bool cubed;
        if (spaceCube.playerMoveable)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                step.Play();
                if (checkFace() == 4)
                {

                    pos = this.gameObject.transform.position;
                    x = pos.x - 1;
                    pos.x = x;
                    //pos.y += 0.01f;//校正用
                    cubed = spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].isCube;
                    if (cubed)
                    {
                        if (!spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y + 1].isCube)
                        {
                            y = pos.y + 1;
                            pos.y = y;
                        }
                        else
                        {
                            y-=1;
                            pos.x = this.gameObject.transform.position.x;
                        }
                    }
                    this.gameObject.transform.position = pos;
                }
                else
                {
                    turnFace("up");
                }
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                step.Play();
                if (checkFace() == 1)
                {
                    pos = this.gameObject.transform.position;
                    x = pos.x + 1;
                    pos.x = x;
                    //pos.y += 0.01f;//校正用
                    cubed = spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].isCube;
                    Debug.Log("cubed: " + cubed);
                    Debug.Log("position: " + (int)pos.x + " " + (int)pos.z + " " + (int)pos.y + " ");
                    if (cubed)
                    {
                        if (!spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y + 1].isCube)
                        {
                            y = pos.y + 1;
                            pos.y = y;
                        }
                        else
                        {
                            y -= 1;
                            pos.x = this.gameObject.transform.position.x;
                        }
                    }
                    this.gameObject.transform.position = pos;
                }
                else
                {
                    turnFace("down");
                }
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                step.Play();
                if (checkFace() == 2)
                {

                    pos = this.gameObject.transform.position;
                    z = pos.z - 1;
                    pos.z = z;
                    //pos.y += 0.01f;//校正用
                    cubed = spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].isCube;
                    if (cubed)
                    {
                        if (!spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y + 1].isCube)
                        {
                            y = pos.y + 1;
                            pos.y = y;
                        }
                        else
                        {
                            y -= 1;
                            pos.z = this.gameObject.transform.position.z;
                        }
                    }
                    this.gameObject.transform.position = pos;
                }
                else
                {
                    turnFace("left");
                }
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                step.Play();
                if (checkFace() == 3)
                {

                    pos = this.gameObject.transform.position;
                    z = pos.z + 1;
                    pos.z = z;
                   // pos.y += 0.01f;//校正用
                    cubed = spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y].isCube;

                    if (cubed)
                    {
                        if (!spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y + 1].isCube)
                        {
                            y = pos.y + 1;
                            pos.y = y;
                        }
                        else
                        {
                            y -= 1;
                            pos.z = this.gameObject.transform.position.z;
                        }
                    }
                    this.gameObject.transform.position = pos;
                }
                else
                {
                    turnFace("right");
                }
            }
        }
    }

    public int checkFace()
    {
        Vector3 faceVec3 = this.gameObject.transform.localEulerAngles;
        float faceY = faceVec3.y;
        int face=1;

        
        if (faceY>=-1&&faceY<90)
        {
            face = 1;
        }
        else if (faceY==270)
        {
            face = 3;
        }
        else if (faceY==90)
        {
            face = 2;
        }
        else 
        {
            face = 4;
        }
        //Debug.Log(face);
        return face;
    }

    void turnFace(string facement)
    {
        if (facement == "up")
        {
            //this.gameObject.transform.Rotate(this.gameObject.transform.rotation.x, 180, this.gameObject.transform.rotation.z);
            this.gameObject.transform.localEulerAngles = new Vector3(this.gameObject.transform.localEulerAngles.x, 180, this.gameObject.transform.localEulerAngles.z);
            //this.gameObject.transform.rotation = new Quaternion(this.gameObject.transform.rotation.x, 180, this.gameObject.transform.rotation.z, this.gameObject.transform.rotation.w);
            //Debug.Log("up"+this.gameObject.transform.localEulerAngles);
        }
        else if (facement == "down")
        {
            this.gameObject.transform.localEulerAngles = new Vector3(this.gameObject.transform.localEulerAngles.x, 0, this.gameObject.transform.localEulerAngles.z);
            //this.gameObject.transform.rotation = new Quaternion(this.gameObject.transform.rotation.x, 0, this.gameObject.transform.rotation.z, this.gameObject.transform.rotation.w);
            //Debug.Log("down" + this.gameObject.transform.localEulerAngles);
        }
        else if (facement == "left")
        {
            this.gameObject.transform.localEulerAngles = new Vector3(this.gameObject.transform.localEulerAngles.x, 90, this.gameObject.transform.localEulerAngles.z);
            //this.gameObject.transform.rotation = new Quaternion(this.gameObject.transform.rotation.x, 90, this.gameObject.transform.rotation.z, this.gameObject.transform.rotation.w);
            //Debug.Log("left");
        }
        else if (facement == "right")
        {
            this.gameObject.transform.localEulerAngles = new Vector3(this.gameObject.transform.localEulerAngles.x, -90, this.gameObject.transform.localEulerAngles.z);
            //this.gameObject.transform.rotation = new Quaternion(this.gameObject.transform.rotation.x, -90, this.gameObject.transform.rotation.z, this.gameObject.transform.rotation.w);
            //Debug.Log("right" + this.gameObject.transform.localEulerAngles);
        }
    }
}

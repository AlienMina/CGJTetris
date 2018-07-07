using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drySponge : MonoBehaviour {
    /// <summary>
    /// 这里是海绵方块的吸水效果存放处
    /// </summary>
    public Base spaceCube;
    public GameObject wetSponge;
    public GameObject water;

    Vector3 pos;
    bool finishAbsorb = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (spaceCube == null)
        {
            spaceCube=GameObject.Find("Main Camera").GetComponent<Base>();
        }
        if (wetSponge == null)
        {
            wetSponge = GameObject.Find("wetSponge");
        }
        if (water == null)
        {
            water = GameObject.Find("water");
        }
	}
    private void FixedUpdate()
    {
        if(water.transform.position.y-this.gameObject.transform.position.y>=-0.5 && !finishAbsorb)
        {
            absorb();
            finishAbsorb = true;
            Debug.Log("BOOM");
        }
    }


    void absorb()
    {
        //吸水时首先确定自身位置
        pos = this.gameObject.transform.position;
        Vector3 position;
        //周围一圈，如果有空隙，那么在这些位置生成吸水的海绵
        if ((int)pos.x - 1 >= 0)
        {
            if (!spaceCube.field[(int)pos.x - 1, (int)pos.z, (int)pos.y].isCube)
            {
                spaceCube.field[(int)pos.x - 1, (int)pos.z, (int)pos.y].isCube = true;
                position = new Vector3((int)pos.x - 1, (int)pos.y, (int)pos.z);
                GameObject.Instantiate(wetSponge, position, new Quaternion(0, 0, 0, 0));
            }
        }
        if ((pos.x + 1) < 7)
        {
            if (!spaceCube.field[(int)pos.x + 1, (int)pos.z, (int)pos.y].isCube)
            {
                spaceCube.field[(int)pos.x + 1, (int)pos.z, (int)pos.y].isCube = true;
                position = new Vector3((int)pos.x + 1, (int)pos.y, (int)pos.z);
                GameObject.Instantiate(wetSponge, position, new Quaternion(0, 0, 0, 0));
            }
        }
        if ((pos.z - 1) >= 0)
        {
            if (!spaceCube.field[(int)pos.x, (int)pos.z - 1, (int)pos.y].isCube)
            {
                spaceCube.field[(int)pos.x, (int)pos.z - 1, (int)pos.y].isCube = true;
                position = new Vector3((int)pos.x, (int)pos.y, (int)pos.z - 1);
                GameObject.Instantiate(wetSponge, position, new Quaternion(0, 0, 0, 0));
            }
        }
        if ((pos.z + 1) < 7)
        {
            if (!spaceCube.field[(int)pos.x, (int)pos.z + 1, (int)pos.y].isCube)
            {
                spaceCube.field[(int)pos.x, (int)pos.z + 1, (int)pos.y].isCube = true;
                position = new Vector3((int)pos.x, (int)pos.y, (int)pos.z + 1);
                GameObject.Instantiate(wetSponge, position, new Quaternion(0, 0, 0, 0));
            }
        }
        if ((pos.y - 1 >= 0))
        {
            if(!spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y - 1].isCube)
            {
                spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y - 1].isCube = true;
                position=new Vector3((int)pos.x, (int)pos.y-1, (int)pos.z);
                GameObject.Instantiate(wetSponge, position, new Quaternion(0, 0, 0, 0));
            }
        }
        if ((pos.y + 1 <= 999))
        {
            if (!spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y + 1].isCube)
            {
                spaceCube.field[(int)pos.x, (int)pos.z, (int)pos.y + 1].isCube = true;
                position = new Vector3((int)pos.x, (int)pos.y + 1, (int)pos.z);
                GameObject.Instantiate(wetSponge, position, new Quaternion(0, 0, 0, 0));
            }
        }
        finishAbsorb = true;

    }
}

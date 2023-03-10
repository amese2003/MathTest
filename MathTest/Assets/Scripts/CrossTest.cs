using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossTest : MonoBehaviour
{
    public GameObject _pivot, _start, _end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 test;
        Vector3 objPos = transform.position;

        Vector3 pivotPos = _pivot.transform.position;
        Vector3 startPos = _start.transform.position;
        Vector3 endPos = _end.transform.position;

        Vector3 ptos = startPos - pivotPos;
        Vector3 ptoe = endPos - pivotPos;
        Vector3 ptom = objPos - pivotPos;

        ptos = ptos.normalized;
        ptoe = ptoe.normalized;
        ptom = ptom.normalized;

        Vector3 sXm = Vector3.Cross(ptos, ptom);
        Vector3 eXm = Vector3.Cross(ptom, ptoe);

        Vector4 testpos = new Vector4(10, 10, 10, 1);
        //Matrix4x4 testScale = new Matrix4x4(new Vector4(1, 0, 0, 0), new Vector4(0, 1, 0, 0), new Vector4(0, 0, 0, 1), new Vector4(0, 0, 0, 1));

        //testpos *= testScale;



        if (sXm.z >= 0 && eXm.z >= 0)
        {
            Debug.Log(sXm);
        }

    }
}

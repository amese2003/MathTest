using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriTest : MonoBehaviour
{
    public GameObject _start;
    public GameObject _end;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 startPos = _start.transform.position;
        Vector3 endPos = _end.transform.position;

        Vector3 dir = endPos - startPos;
        Vector3 mousePos = Input.mousePosition;

        dir = dir.normalized;
        float dot = Vector3.Dot(dir, mousePos);

        transform.position = startPos + dir * dot; 
    }
}

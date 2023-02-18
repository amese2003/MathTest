using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriTest : MonoBehaviour
{
    public GameObject _start;
    public GameObject _end;

    public GameObject _pivot, _movesphere;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 startPos = _start.transform.position;
        Vector3 endPos = _end.transform.position;

        Vector3 dir = endPos - startPos;
        Vector3 pivotPos = _pivot.transform.position;

        dir = dir.normalized;
        float dot = Vector3.Dot(dir, pivotPos);

        _movesphere.transform.position = startPos + dir * dot; 
    }
}

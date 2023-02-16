using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMath : MonoBehaviour
{
    public float _xPos, _yPos;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 12f)
        {
            float x = transform.position.x + (Time.deltaTime * 1f);
            //float z = transform.position.z + (Time.deltaTime * 1f);
            Vector3 newPos = new Vector3(x, Quadraticequation(x % 4), 0);
            transform.position = newPos;
        }
    }

    public float Quadraticequation(float x)
    {
        float y = -x * (x - 4);
        return y;
    }
}

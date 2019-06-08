using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goose : MonoBehaviour
{

    public int score = 0;
    // float num = 3.45f;
    // string name = "matt";
    // bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        // for(int i = 0; i <= 10; i++)
        //     Print();
        transform.position = new Vector3(1,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Print()
    {
        Debug.Log(Calculate());
    }

    int Calculate()
    {
        return 2;
    }
}

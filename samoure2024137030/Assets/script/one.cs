using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one : MonoBehaviour
{
    public int Hp = 100;           //체력 100 선언
    public float heigt = 180.5f;   //높이 180.5 선언

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Hp);
        Debug.Log(heigt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

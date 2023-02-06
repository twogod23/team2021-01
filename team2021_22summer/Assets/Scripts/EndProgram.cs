using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndProgram : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Escキーを押した際
        if (Input.GetKey(KeyCode.Escape))
        {
            //プログラムを終了
            Application.Quit();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomenDestroy : MonoBehaviour
{
    public GameObject somen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posN = somen.transform.position.x;

        if (posN > 35.0f)
        {
            Destroy(somen);
        }
    }
}

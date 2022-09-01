using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoodleDestroy : MonoBehaviour
{
    public GameObject somen;
    public GameObject noodle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posS = somen.transform.position.y;
        float posN = noodle.transform.position.y;
        float pos = Mathf.Abs(posS - posN);

        if(pos >= 5.0f)
        {
            Destroy(noodle);
        }
    }
}

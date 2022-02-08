using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCollect : MonoBehaviour
{

    public Text Scoretxt;
    float Scorevalue = 0;

    // Start is called before the first frame update
    void Start()
    {
        Scoretxt.text = "Score: " + Scorevalue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            Scorevalue++;
            Scoretxt.text = "Score: " + Scorevalue;
            Destroy(other.gameObject);
        }
    }
}

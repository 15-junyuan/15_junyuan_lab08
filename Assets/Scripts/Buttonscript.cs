using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttonscript : MonoBehaviour
{
    public void restartbtn()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

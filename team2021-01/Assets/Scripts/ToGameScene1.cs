using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameScene1 : MonoBehaviour
{
    public void select()
    {
        SceneManager.LoadScene("GameScene1");
    }
}

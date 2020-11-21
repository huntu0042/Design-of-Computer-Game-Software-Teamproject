using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneChange()
    {
        SceneManager.LoadScene("scene_stage1");
    }

    public void SceneChange_2()
    {
        SceneManager.LoadScene("scene_stage2");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

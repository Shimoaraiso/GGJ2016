using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{

    public int offSet_stage1_X;
    public int offSet_stage1_Y;
    public static int mode = 0;
    public Texture button1;

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 + offSet_stage1_X, Screen.height / 2 + offSet_stage1_Y, 220, 80), button1))
        {
            SceneManager.LoadScene("Guide");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 120, 200, 40), "Normal"))
        {
            mode = 0;
            
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 160, 200, 40), "Hard"))
        {
            mode = 1;
            
        }
    }
    void Update()
    {
        if(mode == 0)
        {
            GameObject.Find("Text").GetComponent<TextMesh>().text = "NORMAL Mode";
        }
        else
        {
            GameObject.Find("Text").GetComponent<TextMesh>().text = " HARD  Mode";
        }
    }
}

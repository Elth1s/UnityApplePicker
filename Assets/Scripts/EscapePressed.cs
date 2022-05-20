using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapePressed : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("_Scene_Begin");
    }
}
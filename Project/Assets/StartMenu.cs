using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    public void StartDifficulty()
    {
        SceneManager.LoadScene(1);
        SoundManager.Instance.PlaySound(_clip);
    }

    public void StartOptions()
    {
        SoundManager.Instance.PlaySound(_clip);
    }
    public void StartQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    private void Start()
    {
        Cursor.visible = true;
    }
}

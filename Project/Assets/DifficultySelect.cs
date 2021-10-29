using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DifficultySelect : MonoBehaviour
{
    public Slider difficultyslider;
    public static float difficultyvalue = 1;

    [SerializeField] private AudioClip _clip;
    public void StartGame()
    {
        SceneManager.LoadScene(2);
        SoundManager.Instance.PlaySound(_clip);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        SoundManager.Instance.PlaySound(_clip);
    }
    public void ChangeDiff()
    {
       difficultyvalue = difficultyslider.value;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    void Start()
    {
        _slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeVolume(val));
    }
}

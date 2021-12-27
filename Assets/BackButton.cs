using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    public void Back()
    {
        SoundManager.Instance.PlaySound(_clip);
    }
}

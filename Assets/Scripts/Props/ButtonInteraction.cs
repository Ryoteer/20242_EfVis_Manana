using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour, IInteract
{
    private bool _isOn = false;

    private Animator _anim;

    private void Start()
    {
        _anim = GetComponentInParent<Animator>();
    }

    public void OnInteract()
    {
        _isOn = !_isOn;

        _anim.SetBool("isOn", _isOn);
        _anim.SetTrigger("onEnable");
    }
}

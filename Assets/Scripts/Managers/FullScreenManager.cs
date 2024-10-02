using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreenManager : MonoBehaviour
{
    #region Singleton
    public static FullScreenManager Instance;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    [Header("<color=red>Color Adjustment</color>")]
    [SerializeField] private Material _colAdjPP;
    public Material ColAdjPP 
    { 
        get { return _colAdjPP; } 
        set { _colAdjPP = value; } 
    }

    [Header("<color=red>Vignette</color>")]
    [SerializeField] private Material _vignettePP;
    public Material VignettePP
    {
        get { return _vignettePP; }
        set { _vignettePP = value; }
    }

    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    public void PostProcessState(bool isActive)
    {
        _anim.SetBool("isActive", isActive);
        _anim.SetTrigger("onEnabled");
    }
}

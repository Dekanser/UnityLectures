using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GopherScript : MonoBehaviour
{

    public Animator AnimGopher;
    public Animator AnimHydra;

    public bool CanPunch = true;

    void Start()
    {

    }


    void Update()
    {

    }

    public void Punch() 
    {
        if(CanPunch)
        {
            StartCoroutine(PunchDelayed());
        }
    }

    IEnumerator PunchDelayed()
    {
        CanPunch = false;
        AnimHydra.SetBool("Fall", true);
        yield return new WaitForSeconds(0.5f);
        AnimHydra.SetBool("Fall", false);
        CanPunch = true;

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Transform Hand;
    public Vector3 StartPoint;
    public Vector3 NewPoint;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Punch();
        }

    }

    public void Punch()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000))
        {
            GopherScript gopher = hit.collider.gameObject.GetComponent<GopherScript>();

            if (gopher != null)
            {
                Debug.Log(gopher.name);
                gopher.Punch();
            }
        }

    }

    public IEnumerator MoveTo(Vector3 point)
    {
        NewPoint = point;
        anim.SetBool("Punch", true);
        yield return new WaitForSeconds(1f);
        NewPoint = StartPoint;
        anim.SetBool("Punch", false);
        //anim.SetBool("NotPunch", true);
    }
}

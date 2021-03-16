using System.Collections;
using UnityEngine;

public class RayViewer : MonoBehaviour
{

    public float weaponRange = 50f;

    private Camera fpsCam;


    void Start()
    {
        fpsCam = GetComponentInParent<Camera>();
    }


    void Update()
    {
        Vector3 lineOrgin = fpsCam.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 0.0f));
        Debug.DrawRay(lineOrgin, fpsCam.transform.forward * weaponRange, Color.green);
    }
}

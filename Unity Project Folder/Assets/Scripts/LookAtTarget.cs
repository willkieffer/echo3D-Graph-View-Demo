using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public GameObject target;
    public GameObject main;

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            if(main.GetComponent<MeshRenderer>() == null)
            {
                main.AddComponent<MeshRenderer>();
            }
            main.transform.LookAt(new Vector3(target.transform.position.x, 0, target.transform.position.z));
        }
    }
}

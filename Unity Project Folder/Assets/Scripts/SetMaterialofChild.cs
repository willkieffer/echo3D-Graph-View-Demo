using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterialofChild : MonoBehaviour
{

    public Material mat;
    public GameObject originalGameObject;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (originalGameObject != null)
		{
			GameObject child = originalGameObject.transform.GetChild(0).gameObject;
			GameObject child2 = child.transform.GetChild(0).gameObject;

			if (child2.GetComponent<Renderer>() == null)
			{
				child.AddComponent<Renderer>();
			}

			child2.GetComponent<Renderer>().material = mat;
			
		}

	}
}

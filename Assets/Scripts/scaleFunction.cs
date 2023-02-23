using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class scaleFunction : MonoBehaviour
{

	[SerializeField]
	ARRaycastManager m_RaycastManager;
	List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();

	Camera arCam;
	GameObject focusObject;

	[SerializeField]
	GameObject target;

    void Start()
    {
		arCam = GameObject.Find("AR Camera").GetComponent<Camera>();
		focusObject = null;
    }

	void Update()
	{
		if(target.transform.localScale.y > 1.05)
		{
			target.transform.localScale -= new Vector3(0, 0.05f, 0);
		} 
		else if(target.transform.localScale.y < 0.95)
		{
			target.transform.localScale += new Vector3(0, 0.05f, 0);
		}

		if (Input.touchCount == 0)
			return;

		RaycastHit hit;
		Ray ray = arCam.ScreenPointToRay(Input.GetTouch(0).position);

		if(m_RaycastManager.Raycast(Input.GetTouch(0).position, m_Hits))
		{
			if(Input.GetTouch(0).phase == TouchPhase.Began && focusObject == null)
			{
				if(Physics.Raycast(ray, out hit))
				{
					if(hit.collider.gameObject.tag == "Function")
					{
						//tapping the object
						focusObject = hit.collider.gameObject;
					}
					else
					{
						//tapping places NOT the object
					}
				}
			}
			else if(Input.GetTouch(0).phase == TouchPhase.Moved && focusObject != null)
			{
				//dragging the object
				focusObject.transform.position = m_Hits[0].pose.position;
			}
			else if(Input.GetTouch(0).phase == TouchPhase.Stationary && focusObject != null)
			{
				//holding the object
				target.transform.localScale += new Vector3(0, 0.3f, 0);
			}
			if(Input.GetTouch(0).phase == TouchPhase.Ended)
			{
				//done with touch
				focusObject = null;
			}
		}
	}

}

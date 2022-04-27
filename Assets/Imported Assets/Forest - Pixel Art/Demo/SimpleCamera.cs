using UnityEngine;
using System.Collections;

public class SimpleCamera : MonoBehaviour {

    [SerializeField] private float      m_movementSpeed = 0.5f;
	
	// Update is called once per frame
	void Update () { 
		transform.position += new Vector3(1.0f, 0.0f, 0.0f) * m_movementSpeed * Time.deltaTime;
    }
}

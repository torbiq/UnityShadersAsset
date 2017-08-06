using UnityEngine;
using System.Collections;

public class CameraRotator : MonoBehaviour {

    private Vector2 _prevMousePos,
        _currMousePos;

    private float _rotationSpeed = 0.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            _currMousePos = Input.mousePosition;
        }
	    if (Input.GetMouseButton(0)) {
            _prevMousePos = _currMousePos;
            _currMousePos = Input.mousePosition;

            Vector3 delta = _currMousePos - _prevMousePos;
            delta.z = 0;
            Vector3 rotationAngles = new Vector3(-delta.y, delta.x, delta.z);

            Vector3 final = _rotationSpeed * rotationAngles;

            Camera.main.transform.parent.Rotate(final);
        }
	}
}

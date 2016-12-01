using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCommands : MonoBehaviour {

    private Vector3 resetPosition;
    private Quaternion resetRotation;

	// Use this for initialization
	void Start () {
        resetPosition = transform.localPosition;
        resetRotation = transform.localRotation;
}
    void OnReset() {
        this.GetComponent<Rigidbody>().isKinematic = true;
        transform.localPosition = resetPosition;
        transform.localRotation = resetRotation;
        this.GetComponent<Rigidbody>().isKinematic = false;

    }

}

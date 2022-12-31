using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCamera: MonoBehaviour
{
    public Transform orientation;

    private void Update() {
        this.transform.rotation = orientation.rotation;
        Debug.Log("Changing Rotation: " + this.transform.rotation);
    }
}

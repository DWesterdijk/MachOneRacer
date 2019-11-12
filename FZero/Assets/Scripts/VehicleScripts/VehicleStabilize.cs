using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleStabilize : MonoBehaviour
{
    [SerializeField]
    private GameObject _rayBox;

    private Quaternion _rot;

    void Update()
    {
        _rot = Quaternion.FromToRotation(transform.eulerAngles, _rayBox.transform.eulerAngles) * transform.rotation;
        this.transform.rotation = new Quaternion(this.transform.rotation.x + _rot.x, this.transform.rotation.y + _rot.y, this.transform.rotation.z + _rot.z, 0);
    }
}

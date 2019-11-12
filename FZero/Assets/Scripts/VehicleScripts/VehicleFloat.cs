using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleFloat : MonoBehaviour
{
    //floats
    [SerializeField]
    private float _hoverHeight;
    public float _hoverForce;
    [SerializeField]
    private float _rayOffset;
    [SerializeField]
    private float _rayOffsetAngle;

    //rigidBody
    private Rigidbody _rigidBody;

    private Quaternion _rot;

    private void Awake()
    {
        _rigidBody = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Ray ray = new Ray(new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + _rayOffset), transform.TransformDirection(new Vector3(0, -1, _rayOffsetAngle)));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Ground"))
            {
                //Debug.Log("Hitting Gound!");

                Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + _rayOffset), transform.TransformDirection(new Vector3(0, -1, _rayOffsetAngle)) * hit.distance, Color.yellow);
                //Debug.Log("Raycast Hit");

                float proportionalHeight = (_hoverHeight - hit.distance) / _hoverHeight;
                Vector3 appliedHoverForce = Vector3.up * proportionalHeight * _hoverForce;
                _rigidBody.AddForce(appliedHoverForce, ForceMode.Acceleration);

                _rot = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
                this.transform.rotation = Quaternion.Lerp(this.transform.rotation, _rot, Time.deltaTime * 1.75f);
            }
        }
        else
        {
            Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + _rayOffset), transform.TransformDirection(new Vector3(0, -1, _rayOffsetAngle)) * 1000, Color.red);
            //Debug.Log("miss");
        }
    }
}

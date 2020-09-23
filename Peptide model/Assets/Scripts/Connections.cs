using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connections : MonoBehaviour
{
    public Transform m_peptideBond;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.transform == m_peptideBond)
        {
            gameObject.AddComponent<FixedJoint>().connectedBody = m_peptideBond.GetComponent<Rigidbody>();
            this.enabled = false;
        }
    }
}

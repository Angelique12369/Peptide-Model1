using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceMaintenance : MonoBehaviour
{
    public Transform m_previousSphere;
    public Transform m_nextSphere;
    public float m_bondLength;
    public float m_speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_previousSphere)
        {
            if (Vector3.Distance(m_previousSphere.position,transform.position)>m_bondLength)
            {
                transform.position = Vector3.MoveTowards(transform.position, m_previousSphere.position,m_speed);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, m_previousSphere.position, -m_speed);
            }
        }
        if (m_nextSphere)
        {
            if (Vector3.Distance(m_nextSphere.position, transform.position) > m_bondLength)
            {
                transform.position = Vector3.MoveTowards(transform.position, m_nextSphere.position, m_speed);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, m_nextSphere.position, -m_speed);
            }
        }
    }
}

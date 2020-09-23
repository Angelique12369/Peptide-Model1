using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PeptideFormation : MonoBehaviour
{
    public Transform m_selectedAminoacid;
    public Transform m_backgroundPlane;
    public LayerMask m_defaultLayer;
    public LayerMask m_planeLayer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit, 25, m_defaultLayer))
            {
                    m_selectedAminoacid = hit.transform;
                m_backgroundPlane.position = m_selectedAminoacid.position;
            }
            
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (m_selectedAminoacid)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 25, m_planeLayer))
                {
                    m_selectedAminoacid.position = hit.point;

                }
            }
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            m_selectedAminoacid = null;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermovement : MonoBehaviour
{
    public Rigidbody2D m_RigidBody2D;
    private GameObject m_Character;
    public float m_CharacterSpeed = 1;
    public float SprintSpeed = 1.5f;
    float OriginalSpeed = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        m_Character = GetComponent<GameObject>();
        OriginalSpeed = m_CharacterSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            m_RigidBody2D.velocity = Vector2.up * m_CharacterSpeed;
        }


        else if (Input.GetKey(KeyCode.S) == true)
        {
            m_RigidBody2D.velocity = Vector2.down * m_CharacterSpeed;
        }

        else if (Input.GetKey(KeyCode.A) == true)
        {
            m_RigidBody2D.velocity = Vector2.left * m_CharacterSpeed;
        }

        else if (Input.GetKey(KeyCode.D) == true)
        {
            m_RigidBody2D.velocity = Vector2.right * m_CharacterSpeed;
        }

        else
        {
            m_RigidBody2D.velocity = Vector2.zero;
        }

        if (Input.GetKey(KeyCode.LeftShift) == true)
        {
            m_CharacterSpeed = SprintSpeed;
        }

        else
        {
            m_CharacterSpeed = OriginalSpeed;
        }
    }
}

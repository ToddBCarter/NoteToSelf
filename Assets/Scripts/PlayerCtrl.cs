using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Speed = 5f;
    public float m_JumpPwr = 5f;
    public float m_speedCap = 20f;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            m_JumpPwr = 50f;
        }
        else
        {
            m_JumpPwr = 0f;
        }
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 1, Input.GetAxis("Vertical"));
        
        Vector3 m_Movement = m_Input * m_Speed * Time.fixedDeltaTime;
        m_Rigidbody.MovePosition(m_Rigidbody.position + m_Movement);
        
    }
}
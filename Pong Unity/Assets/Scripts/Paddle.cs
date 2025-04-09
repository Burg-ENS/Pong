using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float movementSpeed;
    public float maxYPosition;
    public int xHitDirection;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("sdfsdf");

        if(Input.GetKey(KeyCode.W))
        {
            MoveUp();
        }
    }

    public void MoveUp()
    {
        transform.Translate(Vector3.up * movementSpeed);
    }


}

using UnityEngine;

public class BodyMovement : MonoBehaviour
{
    private readonly float velocity = (float) 0.005;
    private KeyCode lastPressedKey;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;

        RegisterArrowKeyInput();

        if (lastPressedKey == KeyCode.UpArrow)
        {
            MoveUp(position);
        }

        if (lastPressedKey == KeyCode.DownArrow)
        {
            MoveDown(position);
        }

        if (lastPressedKey == KeyCode.LeftArrow)
        {
            MoveLeft(position);
        }

        if (lastPressedKey == KeyCode.RightArrow)
        {
            MoveRight(position);
        }
    }

    void RegisterArrowKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            lastPressedKey = KeyCode.DownArrow;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            lastPressedKey = KeyCode.UpArrow;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            lastPressedKey = KeyCode.LeftArrow;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            lastPressedKey = KeyCode.RightArrow;
        }
    }

    void MoveUp(Vector3 position)
    {
        position.y += velocity;
        this.transform.position = position;
    }

    void MoveDown(Vector3 position)
    {
        position.y -= velocity;
        this.transform.position = position;
    }

    void MoveLeft(Vector3 position)
    {
        position.x -= velocity;
        this.transform.position = position;
    }

    void MoveRight(Vector3 position)
    {
        position.x += velocity;
        this.transform.position = position;
    }
}
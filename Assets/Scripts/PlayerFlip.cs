using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    private const string Axis = "Horizontal";

    private void FixedUpdate()
    {
        Flip();
    }

    private void Flip()
    {
        if (Input.GetAxisRaw(Axis) > 0)
        {
            transform.localScale = new Vector2(1, 1);
        }
        else if (Input.GetAxisRaw(Axis) < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }
    }
}

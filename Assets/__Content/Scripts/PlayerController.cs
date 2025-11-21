using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 move;

    private void Update()
    {
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    private void FixedUpdate()
    {
        Vector3 pos = new Vector3(move.x, move.y, 0);
        transform.position = transform.position + pos * 8 * Time.deltaTime;
    }
}

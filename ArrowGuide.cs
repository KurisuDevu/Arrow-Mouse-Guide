using UnityEngine;

public class ArrowGuide : MonoBehaviour
{
    public Transform playerPos;
    public float radius;

    private void Update() {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y, mousePos.x);

        transform.position = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * radius + (Vector2)playerPos.position;
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, angle * Mathf.Rad2Deg - 90f);
    }
}

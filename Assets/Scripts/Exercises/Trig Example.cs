using UnityEngine;
using UnityEngine.UIElements;

public class TrigExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Debug.DrawLine(Vector3.zero, mousePos, Color.cyan);

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        Debug.Log($"<color=yellow><size=16>{angle}</size></color>"); //can use variables in strings in debug logs, this actually changes the text size and colour of the console text
    }
}

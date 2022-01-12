using UnityEngine;
using UnityEngine.Events;

public class PassSystem : MonoBehaviour
{
    public string nameTarget = "­X­X";
    public UnityEvent onPass;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == nameTarget) onPass.Invoke();
    }
}

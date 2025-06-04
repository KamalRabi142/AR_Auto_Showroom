using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ToggleDoor()
    {
        if (animator == null) return;

        if (isOpen)
            animator.SetTrigger("close");
        else
            animator.SetTrigger("open");

        isOpen = !isOpen;
    }
}

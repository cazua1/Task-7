using UnityEngine;

[RequireComponent(typeof(Animator))]

public class PlayerAnimations : MonoBehaviour
{
    private const string Run = "IsRunning";    

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            _animator.SetBool(Run, true);
        }

        else
        {
            _animator.SetBool(Run, false);
        }
    }
}

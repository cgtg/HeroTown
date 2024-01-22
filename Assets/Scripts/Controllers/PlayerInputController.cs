using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;

    protected override void Awake()
    {
        base.Awake();// 부모 먼저 실행
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized; // 케릭터가 보는 방향

        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
        else
        {
            Debug.LogAssertion(newAim.magnitude);
        }
    }

    //public void OnFire(InputValue value)
    //{
    //    Debug.Log("OnFire" + value.ToString());
    //}



    public void OnInteract()
    {
        CallInteractEvent();
    }
}
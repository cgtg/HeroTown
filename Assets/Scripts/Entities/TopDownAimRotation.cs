using System;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    //[SerializeField] private SpriteRenderer armRenderer;
    //[SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }


    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    public void RotateArm(Vector2 direction)
    {
        //Debug.Log(direction.x);
        if (DataManager.Instance.curCharacter == Character.HeroKnight)
            characterRenderer.flipX = direction.x < 0;
        else
            characterRenderer.flipX = direction.x > 0;



        //float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // Rad2Deg radian을 degree로 바꿔줌
        //armRenderer.flipY = MathF.Abs(rotZ) > 90f;
        //characterRenderer.flipX = armRenderer.flipY;
        //armPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}

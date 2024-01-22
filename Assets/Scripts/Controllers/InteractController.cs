using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using TMPro;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    protected TopDownCharacterController _controller;

    [SerializeField] private LayerMask _levelCollisionLayer;
    [SerializeField] private GameObject _interactInfo;
    [SerializeField] private GameObject _dialog;
    [SerializeField] private TextMeshProUGUI talkText;

    private bool IsNearby;
    private NPCType type;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }
    void Start()
    {
        _controller.OnInteractEvent += OnInteract;
    }

    private void OnInteract()
    {
        _interactInfo.SetActive(false);
        if (IsNearby)
        {
            switch (type)
            {
                case NPCType.Moonyungho:
                    talkText.text = "TIL 작성 하셨나요?";
                    break;
                case NPCType.Hanhyoseung:
                    talkText.text = "저 이진호 아닙니다~";
                    break;
                case NPCType.Leehansol:
                    talkText.text = "입실버튼 누르셨나요?";
                    break;
            }
            _dialog.SetActive(true);
        }
    }

    public void HideInteract()
    {
        _interactInfo.SetActive(true);
        _dialog.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_levelCollisionLayer.value == (_levelCollisionLayer.value | (1 << collision.gameObject.layer)))
        {
            //Debug.Log("충돌 중");
            IsNearby = true;
            _interactInfo.SetActive(true);

            NPCStats npcStats = collision.GetComponent<NPCStats>();
            type = npcStats.type;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IsNearby = false;
        _interactInfo.SetActive(false);
        _dialog.SetActive(false);
    }


}

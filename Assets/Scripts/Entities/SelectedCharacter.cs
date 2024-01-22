using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCharacter : MonoBehaviour
{
    private Character curCharacter;
    [SerializeField] private Animator _animator;
    [SerializeField] private RuntimeAnimatorController[] _animCon;
    private RectTransform _rectTransform;

    private void Awake()
    {
        curCharacter = Character.HeroKnight;
    }

    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        _animator.runtimeAnimatorController = _animCon[0];
    }

    void Update()
    {
        if (curCharacter != DataManager.Instance.curCharacter)
        {
            curCharacter = DataManager.Instance.curCharacter;
            switch (DataManager.Instance.curCharacter)
            {
                case Character.HeroKnight:
                    _rectTransform.sizeDelta = new Vector2(100, 55);
                    _rectTransform.anchoredPosition = new Vector2(10, 5);
                    break;
                case Character.LightBandit:
                    _rectTransform.sizeDelta = new Vector2(48, 48);
                    _rectTransform.anchoredPosition = new Vector2(1.5f, 0);
                    break;
            }
        }
        _animator.runtimeAnimatorController = _animCon[(int)curCharacter];
    }
}

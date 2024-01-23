using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private Animator _animator;
    [SerializeField] private RuntimeAnimatorController[] _animCon;
    [SerializeField] private Text _playerName;
    [SerializeField] private TextMeshProUGUI _TextMeshProUGUI;

    public bool IsPlaying { get; set; }

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        IsPlaying = true;
    }

    public void SetCharacter()
    {
        _animator.runtimeAnimatorController = _animCon[(int)DataManager.Instance.curCharacter];
        if (_playerName)
        {
            _playerName.text = DataManager.Instance.myName;
            _TextMeshProUGUI.text = DataManager.Instance.myName;
        }
        IsPlaying = true;
    }
}

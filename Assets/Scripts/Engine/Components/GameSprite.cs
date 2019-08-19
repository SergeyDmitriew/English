using UnityEngine;
using UnityEngine.UI;

public class GameSprite : MonoBehaviour
{
    [SerializeField] private Image _image;

    [SerializeField] private Color _colorHide = Color.white;
    [SerializeField] private Color _colorShow = new Color (1.0f, 1.0f, 1.0f, 0.1f);

    private bool _isShow;

    public bool IsShow
    {
        get { return _isShow; }
        set
        {
            if (value) Show ();
            else Hide ();
        }
    }

    public void Show ()
    {
        _image.color = _colorShow;
        _isShow = true;
    }

    public void Hide ()
    {
        _image.color = _colorHide;
        _isShow = false;
    }
}
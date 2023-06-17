using UnityEngine;
using UnityEngine.Serialization;

public class Death : MonoBehaviour
{
    [SerializeField] private GameObject _back;
    [SerializeField] private GameObject _btnVideo;
    [SerializeField] private GameObject _skip;
    [FormerlySerializedAs("Time")] [SerializeField] private GameObject _time;
    [FormerlySerializedAs("Scope")] [SerializeField] private ScoreController _scoreController;
    
    private void SetActiveFalse()
    {
        _back.SetActive(false);
        _btnVideo.SetActive(false);
        
        _skip.SetActive(true);
        gameObject.SetActive(false);
        
        _time.SetActive(false);
    }
}
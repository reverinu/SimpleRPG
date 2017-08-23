using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageWindowController : MonoBehaviour {

    private string[] _splitText;
    private int _splitNum;
    private int _maxSplitNum;
    [SerializeField] private GameObject MessageWindow;
    [SerializeField] private GameObject MessageText;
    public bool IsMessage;
    public bool IsMessageEnd;
    private bool _isFirstMessage;

    public void StartMessageWindow( string text ){
        _isFirstMessage = true;
        MessageWindow.SetActive( true );
        _splitNum = 0;
        SplitText( text );
        StartCoroutine( "MessageLoop" );
    }
    private void NextMessageWindow(){
        if (_splitNum >= _maxSplitNum) {
            IsMessageEnd = true;
        } else {
            RemoveText();
            SetText();
        }
        _splitNum++;
    }
    private void EndMessageWindow(){
        MessageWindow.SetActive( false );
    }
	private void SetText(){
        MessageText.GetComponent<Text>().text = _splitText[_splitNum];
    }
    private void RemoveText(){
        MessageText.GetComponent<Text>().text = null;
    }
    private void SplitText( string text ){
        // TODO: ここ直しておく
        _splitText = text.Split( "\\"[0] );
        _maxSplitNum = _splitText.Length;
    }

    private IEnumerator MessageLoop(){
        while ( true ) {
            if ( ( !IsMessage && Input.GetKeyDown( KeyCode.Space ) ) || _isFirstMessage ) {
                IsMessage = true;
                _isFirstMessage = false;
            }
            if ( IsMessage ) {
                IsMessage = false;
                NextMessageWindow();
            }
            if ( IsMessageEnd ) {
                IsMessageEnd = false;
                EndMessageWindow();
                StopCoroutine( "MessageLoop" );
            }
            yield return null;
        }
    }
}

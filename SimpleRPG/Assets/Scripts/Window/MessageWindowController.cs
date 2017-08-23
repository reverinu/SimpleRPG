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
    public bool IsMessageLoop;
    public bool IsMessage;
    public bool IsMessageEnd;
    private bool _isFirstMessage;
    [SerializeField] private string n;

    public void StartMessageWindow( string text ){
        _isFirstMessage = true;
        IsMessageLoop = true;
        MessageWindow.SetActive( true );
        _splitNum = 0;
        text = ReplaceText(text, "\n", n );
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
    /*
     * 文字の置き換え.\nがおかしなことになって改行されないので用意した
     */
    private string ReplaceText( string text, string replaceText, string targetText ) {
        System.Text.StringBuilder sb = new System.Text.StringBuilder( text );
        sb.Replace( targetText, replaceText );
        string result = sb.ToString();
        return result;
    }
    private void SplitText( string text ){
        _splitText = text.Split( "#"[0] );
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
                IsMessageLoop = false;
                EndMessageWindow();
                StopCoroutine( "MessageLoop" );
            }
            yield return null;
        }
    }
}

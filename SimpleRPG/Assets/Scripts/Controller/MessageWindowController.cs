using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageWindowController : MonoBehaviour {

    private string[] SplitText;

    public void StartMessageWindow(string text){
        SplitText(text);
        NextMessageWindow();
    }
    public void NextMessageWindow(){

    }
    public void EndMessageWindow(){

    }
	private void SetText(){

    }
    private void RemoveText(){

    }
    private void SplitText(string text){
        SplitText = text.Split( "<next>" );
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * オブジェクト基底クラス
 */
public class ReverObject : MonoBehaviour {

    /* 名前 */
    [SerializeField] private string _name;
    public string Name {
        get { return this._name; }
        protected set { this._name = value; }
    }

    private void Start() {
        this.Name = _name;
    }

}

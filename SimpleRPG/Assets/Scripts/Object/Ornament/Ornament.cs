using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 
 * 置物クラス
 */
public class Ornament : ReverObject {
    /* 設置位置 */
    [SerializeField] private Vector3 _position;
    public Vector3 Position
    {
        get { return this._position; }
        protected set { this._position = value; }
    }

    public bool HasAction;
    public string Message = null;

    private void Start()
    {
        this.Position = _position;
    }


}

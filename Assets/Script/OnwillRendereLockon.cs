using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// OnWillRenderObject()はシーンビューカメラに移ってる時でも呼ばれちゃうから使うな!ってイワナ、書かなかった？コメント
/// まあなにか発見があるかもしれないから多少は、ね？
/// </summary>
public class OnwillRendereLockon : MonoBehaviour
{
    private string _mainCameraTagName = "MainCamera";//const 暗黙的にstatic インスタンスが異なっても常に同じ値 constする意味ないから消した
    static bool _canlockOn = false;
    
    void Update()
    {
        //_canlockOn = false;
        Debug.Log(_canlockOn);
    }

    private void OnWillRenderObject()
    {//これでメインカメラでだけ判定いけんじゃね？
     //いけました 実験は成功だ！
     //イケてねえじゃねえか間抜け
        if(Camera.current.tag==_mainCameraTagName)
        {
            _canlockOn = true;
        }
        else
        {
            _canlockOn = false;
        }
        
    }
}

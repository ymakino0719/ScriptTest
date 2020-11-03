using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53; // MP

    // 魔法攻撃用の関数
    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////// 課題: 配列を宣言して出力しよう //////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////

        // 要素の個数が5の、int型の配列arrayを宣言し、任意の値で初期化
        int[] array = { 3, 5, 8, 13, 21 };

        // for文を使い、配列の各要素の値を順番に表示
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // for文を使い、配列の各要素の値を逆順に表示
        for (int j = 4; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////
        //////// 発展課題: Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出そう ////////
        ////////////////////////////////////////////////////////////////////////////////////////////

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss mage = new Boss();

        // 魔法攻撃用の関数を呼び出す
        for(int k = 0; k < 12; k++)
        {
            mage.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

2022年1月17日(月) 17:00：山本涼太

======================================================================================
- Yamamoto_Scriptsフォルダ内のスクリプト説明
======================================================================================
▼MoveAnim.cs
correctAnim();
・正解時にテキストを呼び出す
　→Canvas/AnimationText/AnswerTextにアタッチ済み
　→動作詳細については、MoveAnim.correctAnim()に記載済み

wrongAnim();
・不正解時にテキストを呼び出す
　→correctAnim()同様のテキストを利用
　→動作詳細については、MoveAnim.wrongAnim()に記載済み

======================================================================================
▼MoveCoin.cs
moveCoinAnim();
・コインが弾かれて、下に落ちていき消えていく動作が入ってます
　→各コインオブジェクトにMoveCoin.csを追加し、
　　moveCoinAnim()を呼ぶと、動作します

======================================================================================

▼OtsukaiMenu.cs
Yamamoto(Scene)/ItemSystemにアタッチ済み
・商品を手動で入れる必要がありますが、
　とてもシンプルな設計となっています。
　→Itemリストを開くと、Element[number]が出てきます。
　　商品メニューを追加する時は「＋」ボタンから項目を増やしてください(現状4つまで可能)
　　商品メニューを削除する時は「ー」ボタンから項目を減らしてください

======================================================================================
▼MyItem.cs
Canvas/OtsukaiPanel/Product1,2,3,4にアタッチ済み
・コード詳細はMyItem.csに記載済み
　→Item System:ItemSystemをアタッチ
　　My Number:Product1=0,2=1,3=2,4=3を記入
　　Product Image:各Product/P_Imageをアタッチ
　　PriceText:各Product/Textをアタッチ(Element0のみ)
　　Customer Image:何もしなくていい
　　Hukidashi:HukidashiPanelオブジェクトのみチェックマークを入れる、
　　　　　　　それ以外は入れない

　→HukidashiPanel/MyItem/PriceTextには、
　　Element0:HukidashiPanel/Product_Price_Textをアタッチ
　　Element1:HukidashiPanel/HintTextをアタッチ
　　Hukidashi:チェックマークを入れる

======================================================================================

※各々、必要なコンポーネントは自動で入れてくれるので、
　手動でコンポーネント追加をする必要はありません。
　　



# 背景にグラデーションをかける
背景色にグラデーションをかけたいと思って調べたらカスタムコントロールを使う必要があることがわかった.

StackLayoutやContentPageなどのコントロールについては情報がたくさんあり,そのとおりの実装で実現できた.

>GradientStackLayout

<img src="https://user-images.githubusercontent.com/43431002/72192908-af360a00-344a-11ea-8d49-e7c10e15307b.jpg" width="200px"/>

しかし,Buttonに対するグラデーションはうまくいかなかった.
実現するためにはもっと時間をかけてつくる必要があるようだ.

でも,ボタンにグラデーションをかけたいというときはあまりないと思うのであきらめた.


# Frameに影をつける
本当はButtonに直接影をつけるようにしたかったが,難しそうということがわかった.

幸いにもFrameに影をつける例は見つけやすかった.

Frameに影をつけ,その中にButtonを配置することで*影付きのボタン*にした.

<img src="https://user-images.githubusercontent.com/43431002/72208425-be1dca80-34e5-11ea-9725-b330d3b039a8.png" width="200px"/>


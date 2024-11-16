## 入力受け取り

行ごと

```f#
let a = stdin.ReadLine() |> int
let b = stdin.ReadLine() |> int
```

スペースで分割

```f#
let [|x; y|] =
  stdin.ReadLine().Split()
    |> Array.map int
```

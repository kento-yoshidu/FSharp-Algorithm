// https://atcoder.jp/contests/abc021/tasks/abc021_a

let run n =
    // リストの先頭に要素を追加
    n :: List.replicate n 1

printfn "%A" (run 5)
//=> [5; 1; 1; 1; 1; 1]

printfn "%A" (run 1)
//=> [1; 1]

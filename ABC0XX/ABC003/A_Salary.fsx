// https://atcoder.jp/contests/abc003/tasks/abc003_1

let run n =
  ([1..n] |> List.sum) * 10000 / n

printfn "%i" (run 6)
//=> 35000

printfn "%i" (run 91)
//=> 460000

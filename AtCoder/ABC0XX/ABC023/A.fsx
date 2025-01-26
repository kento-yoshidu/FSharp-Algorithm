// https://atcoder.jp/contests/abc023/tasks/abc023_a

let run x =
    x / 10 + x % 10

printfn "%i" (run 23)
//=> 5

printfn "%i" (run 70)
//=> 7

printfn "%i" (run 99)
//=> 18

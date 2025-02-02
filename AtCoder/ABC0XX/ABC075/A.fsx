// https://atcoder.jp/contests/abc075/tasks/abc075_a

let run a b c =
    a ^^^ b ^^^ c

printfn "%i" (run 5 7 5)
//=> 7

printfn "%i" (run 1 1 7)
//=> 7

printfn "%i" (run -100 100 100)
//=> 100

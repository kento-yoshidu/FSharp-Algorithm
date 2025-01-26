// https://atcoder.jp/contests/arc015/tasks/arc015_1

let run n =
    9.0 / 5.0 * n + 32.0

printfn "%f" (run 10)
//=> 50.0

printfn "%f" (run 33)
//=> 91.4

printfn "%f" (run -100)
//=> -148.0

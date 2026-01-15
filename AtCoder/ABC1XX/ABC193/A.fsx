// https://atcoder.jp/contests/abc193/tasks/abc193_a

let fn a b =
    float (a - b) / float a * 100.0

printfn "%f" (fn 100 80)
//=> 20.0

printfn "%f" (fn 7 6)
//=> 14.285714

printfn "%f" (fn 99999 99998)
//=> 0.001000

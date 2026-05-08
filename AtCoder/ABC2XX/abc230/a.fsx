// https://atcoder.jp/contests/abc230/tasks/abc230_a

let fn n =
    let x = if n <= 41 then n else n + 1
    sprintf "AGC%03d" x

printfn "%s" (fn 42)
//=> AGC043

printfn "%s" (fn 19)
//=> AGC019

printfn "%s" (fn 1)
//=> AGC001

printfn "%s" (fn 50)
//=> AGC051

// https://atcoder.jp/contests/abc400/tasks/abc400_a

let fn a =
    if 400 % a = 0 then
        400 / a
    else
        -1

printfn "%i" (fn 10)
//=> 40

printfn "%i" (fn 11)
//=> -1

printfn "%i" (fn 400)
//=> 1

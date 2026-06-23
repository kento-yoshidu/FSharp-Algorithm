// https://atcoder.jp/contests/abc207/tasks/abc207_a

let fn a b c =
    let sum = a + b + c
    let minV = min a (min b c)

    sum - minV

printfn "%i" (fn 3 4 5)
//=> 9

printfn "%i" (fn 6 6 6)
//=> 12

printfn "%i" (fn 99 99 98)
//=> 198

// https://atcoder.jp/contests/abc124/tasks/abc124_a

let fn a b =
    if a = b then
        a * 2
    else
        let l = max a b
        l + l - 1

printfn "%i" (fn 5 3)
//=> 9

printfn "%i" (fn 3 4)
//=> 7

printfn "%i" (fn 6 6)
//=> 12

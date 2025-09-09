// https://atcoder.jp/contests/abc100/tasks/abc100_a

let fn a b =
    if max a b <= 8 then
        "Yay!"
    else
        ":("

printfn "%s" (fn 5 4)
//=> Yay!

printfn "%s" (fn 8 8)
//=> Yay!

printfn "%s" (fn 11 4)
//=> :(

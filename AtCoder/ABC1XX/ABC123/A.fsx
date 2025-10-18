// https://atcoder.jp/contests/abc123/tasks/abc123_a

let fn a _ _ _ e k =
    if e - a < k then
        "Yay!"
    else
        ":("

printfn "%s" (fn 1 2 4 8 9 15)
//=> Yay!

printf "%s" (fn 15 18 26 35 36 18)
//=> :(

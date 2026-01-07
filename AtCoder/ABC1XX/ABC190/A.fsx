// https://atcoder.jp/contests/abc190/tasks/abc190_a

let fn a b c =
    if c = 0 then
        if a-1 >= b then
            "Takahashi"
        else
            "Aoki"
    else
        if a > b-1 then
            "Takahashi"
        else
            "Aoki"

printfn "%s" (fn 2 1 0)
//=> Takahashi

printfn "%s" (fn 2 2 0)
//=> Aoki

printfn "%s" (fn 2 2 1)
//=> Takahashi

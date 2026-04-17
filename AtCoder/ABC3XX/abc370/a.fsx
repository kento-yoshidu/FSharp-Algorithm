// https://atcoder.jp/contests/abc370/tasks/abc370_a

let fn l r =
    if l + r = 2 || l + r = 0 then
        "Invalid"
    elif l = 1 && r = 0 then
        "Yes"
    else
        "No"

printfn "%s" (fn 1 0)
//=> Yes

printfn "%s" (fn 1 1)
//=> Invalid

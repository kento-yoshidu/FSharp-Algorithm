// https://atcoder.jp/contests/abc385/tasks/abc385_a

let fn a b c =
    if a = b && b = c then
        "Yes"
    else
        if a + b = c || a + c = b || b + c = a then
            "Yes"
        else
            "No"

printfn "%s" (fn 3 8 5)
//=> Yes

printfn "%s" (fn 2 2 2)
//=> Yes

printfn "%s" (fn 1 2 4)
//=> No

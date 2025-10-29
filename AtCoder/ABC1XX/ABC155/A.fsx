// https://atcoder.jp/contests/abc155/tasks/abc155_a

let fn a b c =
    let s = set [a; b; c]

    if Set.count s = 2 then
        "Yes"
    else
        "No"

printfn "%s" (fn 5 7 5)
//=> Yes

printfn "%s" (fn 4 4 4)
//=> No

printfn "%s" (fn 4 9 6)
//=> No

printfn "%s" (fn 3 3 4)
//=> Yes

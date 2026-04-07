// https://atcoder.jp/contests/abc452/tasks/abc452_a

let fn m d =
    if m = 1 && d = 7 ||
       m = 3 && d = 3 ||
       m = 5 && d = 5 ||
       m = 7 && d = 7 ||
       m = 9 && d = 9 then
        "Yes"
    else
        "No"

printfn "%s" (fn 3 3)
//=> Yes

printfn "%s" (fn 1 1)
//=> No

printfn "%s" (fn 4 4)
//=> No

printfn "%s" (fn 11 7)
//=> No

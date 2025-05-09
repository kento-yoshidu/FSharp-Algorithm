// https://atcoder.jp/contests/abc073/tasks/abc073_a

let run n =
    if n / 10 = 9 || n % 10 = 9 then
        "Yes"
    else
        "No"

printfn "%s" (run 29)
//=> Yes

printfn "%s" (run 72)
//=> 72

printfn "%s" (run 91)
//=> Yes

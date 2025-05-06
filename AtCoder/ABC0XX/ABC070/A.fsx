// https://atcoder.jp/contests/abc070/tasks/abc070_a

let run n =
    if n / 100 = n % 10 then
        "Yes"
    else
        "No"

printfn "%s" (run 575)
//=> Yes

printfn "%s" (run 123)
//=> No

printfn "%s" (run 812)
//=> No

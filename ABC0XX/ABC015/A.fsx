// https://atcoder.jp/contests/abc015/tasks/abc015_1

let run a b =
    if String.length a >= String.length b then
        a
    else
        b

printfn "%s" (run "isuruu" "isleapyear")
//=> isleapyear

printfn "%s" (run "ttttiiiimmmmeeee" "time")
//=> ttttiiiimmmmeeee

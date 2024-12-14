// https://atcoder.jp/contests/abc020/tasks/abc020_a

let run q =
    match q with
    | 1 -> "ABC"
    | 2 -> "chokudai"
    | _ -> failwith ""

printfn "%s" (run 1)
//=> ABC

printfn "%s" (run 2)
//=> chokudai

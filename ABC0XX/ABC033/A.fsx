// https://atcoder.jp/contests/abc033/tasks/abc033_a

let run s =
    if s
        |> Seq.distinct
        |> Seq.length = 1 then
        "SAME"
    else
        "DIFFERENT"

printfn "%s" (run "2222")
//=> SAME

printfn "%s" (run "1221")
//=> DIFFERENT

printfn "%s" (run "0000")
//=> SAME

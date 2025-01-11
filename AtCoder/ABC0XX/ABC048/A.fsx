// https://atcoder.jp/contests/abc048/tasks/abc048_a

let run _ (b: string) _ =
    "A" + string b.[0] + "C"

printfn "%s" (run "AtCoder" "Beginner" "Contest")
//=> ABC

printfn "%s" (run "AtCoder" "Snuke" "Contest")
//=> ASC

printfn "%s" (run "AtCoder" "X" "Contest")
//=> AXC

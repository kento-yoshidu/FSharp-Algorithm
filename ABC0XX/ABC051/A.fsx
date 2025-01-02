// https://atcoder.jp/contests/abc051/tasks/abc051_a

let run (s: string) =
    s.Replace(",", " ")

printfn "%s" (run "happy,newyear,enjoy")
//=> happy newyear enjoy

printfn "%s" (run "haiku atcoder tasks")
//=> haiku atcoder tasks

printfn "%s" (run "abcde fghihgf edcba")
//=> abcde fghihgf edcba

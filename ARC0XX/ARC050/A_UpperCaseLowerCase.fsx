// https://atcoder.jp/contests/arc050/tasks/arc050_a

open System

let run c1 c2 =
  if Char.ToLower(c1) = c2 then
    "Yes"
  else
    "No"

printfn "%s" (run 'A' 'a')
//=> Yes

printfn "%s" (run 'B' 'c')
//=> No

printfn "%s" (run 'Z' 'z')
//=> Yes

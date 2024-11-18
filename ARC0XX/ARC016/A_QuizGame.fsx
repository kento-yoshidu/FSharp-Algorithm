// https://atcoder.jp/contests/arc016/tasks/arc016_1

let run n m =
  if n = m then 1
  else n

printfn "%i" (run 4 4)
//=> 1

printfn "%i" (run 2 1)
//=> 2

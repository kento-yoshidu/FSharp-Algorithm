// https://atcoder.jp/contests/abc119/tasks/abc119_a

let fn (s: string) =
     if int (s.Split('/').[1]) > 4 then "TBD" else "Heisei"

printfn "%s" (fn "2019/04/30")
//=> Heisei

printfn "%s" (fn "2019/11/01")
//=> TBD

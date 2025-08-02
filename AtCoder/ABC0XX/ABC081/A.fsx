// https://atcoder.jp/contests/abc081/tasks/abc081_a

let fn (s: string) =
    s |> Seq.filter(fun c -> c = '1')
      |> Seq.length

printfn "%i" (fn "101")
//=> 2

printfn "%i" (fn "000")
//=> 0

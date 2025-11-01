// https://atcoder.jp/contests/abc139/tasks/abc139_a

let fn s t =
    Seq.zip s t
    |> Seq.filter (fun (a, b) -> a = b)
    |> Seq.length

printfn "%i" (fn "CSS" "CSR")
//=> 2

printfn "%i" (fn "SSR" "SSR")
//=> 3

printfn "%i" (fn "RRR" "SSS")
//=> 0

// https://atcoder.jp/contests/abc348/tasks/abc348_a

let fn n =
    seq {1..n}
        |> Seq.map (fun i -> if i % 3 = 0 then 'x' else 'o')
        |> Seq.map string
        |> String.concat ""

printfn "%s" (fn 7)
//=> ooxooxo

printfn "%s" (fn 9)
//=> ooxooxoox

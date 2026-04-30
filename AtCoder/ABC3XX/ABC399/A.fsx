// https://atcoder.jp/contests/abc399/tasks/abc399_a

let fn n s t =
    Seq.zip s t
    |> Seq.filter (fun (a, b) -> a <> b)
    |> Seq.length

printfn "%i" (fn 6 "abcarc" "agcahc")
//=> 2

printfn "%i" (fn 7 "atcoder" "contest")
//=> 7

printfn "%i" (fn 8 "chokudai" "chokudai")
//=> 0

printfn "%i" (fn 10 "vexknuampx" "vzxikuamlx")
//=> 4

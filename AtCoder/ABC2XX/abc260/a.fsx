// https://atcoder.jp/contests/abc260/tasks/abc260_a

let fn s =
    s
    |> Seq.countBy id
    |> Seq.tryFind (fun (_, c) -> c = 1)
    |> Option.map (fun (c, _) -> string c)
    |> Option.defaultValue "-1"

printfn "%s" (fn "pop")
//=> o

printfn "%s" (fn "abc")
//=> a

printfn "%s" (fn "xxx")
//=> -1

// https://atcoder.jp/contests/abc394/tasks/abc394_a

let fn (s: string) =
    s
    |> Seq.filter (fun c -> c = '2')
    |> Seq.toArray
    |> System.String

printfn "%s" (fn "20250222")
//=> 22222

printfn "%s" (fn "2")
//=> 2

printfn "%s" (fn "22222000111222222")
//=> 22222222222

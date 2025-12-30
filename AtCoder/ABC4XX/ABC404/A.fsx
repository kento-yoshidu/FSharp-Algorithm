// https://atcoder.jp/contests/abc404/tasks/abc404_a

let fn s =
    [| 'a' .. 'z' |]
    |> Array.find (fun c -> not (Seq.contains c s))

printfn "%c" (fn "a")
//=> b

printfn "%c" (fn "abcdfhijklmnopqrstuvwxyz")
//=> e

printfn "%c" (fn "qazplwsxokmedcijnrfvuhbgt")
//=> y

// https://atcoder.jp/contests/abc095/tasks/abc095_a

let fn s =
    let count =
        s
        |> String.filter (fun c -> c = 'o')
        |> String.length

    count * 100 + 700

printfn "%i" (fn "oxo")
//=> 900

printfn "%i" (fn "ooo")
//=> 1000

printfn "%i" (fn "xxx")
//=> 700

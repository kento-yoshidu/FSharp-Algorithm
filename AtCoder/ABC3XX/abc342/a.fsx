// https://atcoder.jp/contests/abc342/tasks/abc342_a

let fn (s: string) =
    let oddChar =
        s
        |> Seq.groupBy id
        |> Seq.find (fun (_, g) -> Seq.length g = 1)
        |> fst

    s.IndexOf(oddChar) + 1

printfn "%i" (fn "yay")
//=> 2

printfn "%i" (fn "egg")
//=> 1

printfn "%i" (fn "zzzzzwz")
//=> 6

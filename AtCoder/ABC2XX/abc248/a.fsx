// https://atcoder.jp/contests/abc248/tasks/abc248_a

let fn (s: string) =
    seq { 0..9 }
        |> Seq.find (fun i -> not (s.Contains(string i)))

printfn "%i" (fn "023456789")
//=> 1

printfn "%i" (fn "459230781")
//=> 6

// https://atcoder.jp/contests/agc054/tasks/agc054_a

let run n (s: string) =
    if s.[0] <> s.[s.Length-1] then
        1
    else
        match
            s
            |> Seq.windowed 2
            |> Seq.tryFind (function
                | [| x; y|] when s.[0] <> x && s.[0] <> y -> true
                | _ -> false)
        with
        | Some _ -> 2
        | None -> -1

printfn "%i" (run 4 "abba")
//=> 2

printfn "%i" (run 3 "aba")
//=> -1

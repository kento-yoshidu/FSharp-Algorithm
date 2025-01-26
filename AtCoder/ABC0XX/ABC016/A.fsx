// https://atcoder.jp/contests/abc296/tasks/abc296_a

let run n s =
    match n with
    | 1 -> "Yes"
    | _ ->
        let windows = Seq.windowed 2 s
        if Seq.forall (fun window ->
            match window with
                | [|a; b|] -> a <> b
                | _ -> false) windows then
            "Yes"
        else
            "No"

printfn "%s" (run 6 "MFMFMF")
//=> Yes

printfn "%s" (run 9 "FMFMMFMFM")
//=> No

printfn "%s" (run 1 "F")
//=> Yes

printfn "%s" (run 2 "FF")
//=> No

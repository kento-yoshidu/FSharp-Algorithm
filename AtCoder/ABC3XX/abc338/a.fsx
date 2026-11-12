// https://atcoder.jp/contests/abc338/tasks/abc338_a

let fn (s: string) =
    if System.Char.IsUpper s.[0] && s.[1..] |> Seq.forall (fun c -> not (System.Char.IsUpper c)) then
        "Yes"
    else
        "No"

printfn "%s" (fn "Capitalized")
//=> Yes

printfn "%s" (fn "AtCoder")
//=> No

printfn "%s" (fn "yes")
//=> No

printfn "%s" (fn "A")
//=> Yes

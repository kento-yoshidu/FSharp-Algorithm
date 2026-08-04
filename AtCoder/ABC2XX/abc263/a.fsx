// https://atcoder.jp/contests/abc263/tasks/abc263_a

let fn a b c d e =
    let counts =
        [ a; b; c; d; e ]
        |> Seq.countBy id
        |> Seq.map snd
        |> Seq.sort
        |> List.ofSeq

    if counts = [ 2; 3 ] then
        "Yes"
    else
        "No"

printfn "%s" (fn 1 2 1 2 1)
//=> Yes

printfn "%s" (fn 12 12 11 1 2)
//=> No

// https://atcoder.jp/contests/abc229/tasks/abc229_a

let fn s1 s2 =
    let s1Count = s1 |> Seq.filter (fun c -> c = '#') |> Seq.length
    let s2Count = s2 |> Seq.filter (fun c -> c = '#') |> Seq.length

    if s1Count + s2Count >= 3 then
        "Yes"
    else
        "No"

printfn "%s" (fn "##" ".#")
//=> Yes

printfn "%s" (fn ".#" "#.")
//=> No

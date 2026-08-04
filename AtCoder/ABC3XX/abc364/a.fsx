// https://atcoder.jp/contests/abc364/tasks/abc364_a

let fn _n (s: string array) =
    let n = s.Length
    if n = 1 then "Yes"
    else
        [0 .. n - 3]
        |> List.exists (fun i ->
            s.[i] = "sweet" && s.[i + 1] = "sweet"
        )
        |> function true -> "No" | false -> "Yes"

printfn "%s" (fn 5 [| "salty"; "sweet"; "salty"; "salty"; "sweet" |])
//=> Yes

printfn "%s" (fn 4 [| "sweet"; "salty"; "sweet"; "sweet" |])
//=> No

printfn "%s" (fn 6 [| "salty"; "sweet"; "sweet"; "salty"; "sweet"; "sweet" |])
//=> No

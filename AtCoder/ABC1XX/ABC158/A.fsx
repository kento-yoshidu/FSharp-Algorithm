// https://atcoder.jp/contests/abc158/tasks/abc158_a

let fn s =
    let chars = Seq.toList s

    match List.contains 'A' chars, List.contains 'B' chars with
    | true, true -> "Yes"
    | _ -> "No"

printfn "%s" (fn "ABA")
//=> Yes

printfn "%s" (fn "BBA")
//=> Yes

printfn "%s" (fn "BBB")
//=> No

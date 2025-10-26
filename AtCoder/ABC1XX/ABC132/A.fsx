// https://atcoder.jp/contests/abc132/tasks/abc132_a

let fn (s: string) =
    let chars =
        s.ToCharArray()
        |> Array.distinct

    if chars.Length = 2 then
        "Yes"
    else
        "No"

printfn "%s" (fn "ASSA")
//=> Yes

printfn "%s" (fn "STOP")
//=> No

printfn "%s" (fn "FFEE")
//=> Yes

printfn "%s" (fn "FREE")
//=> No

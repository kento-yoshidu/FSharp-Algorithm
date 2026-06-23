// https://atcoder.jp/contests/abc350/tasks/abc350_a

let fn (s: string) =
    let contest = s.Substring(3, 3) |> int

    if contest <> 316 && contest < 350 then
        "Yes"
    else
        "No"


printfn "%s" (fn "ABC349")
//=> Yes

printfn "%s" (fn "ABC350")
//=> No

printfn "%s" (fn "ABC316")
//=> No

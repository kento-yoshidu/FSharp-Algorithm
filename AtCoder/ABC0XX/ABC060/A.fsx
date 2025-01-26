// https://atcoder.jp/contests/abc060/tasks/abc060_a

let run (a: string) (b: string) (c: string) =
    let aLast = a.[a.Length - 1]
    let bFirst = b.[0]
    let bLast = b.[b.Length - 1]
    let cFirst = c.[0]

    if aLast = bFirst && bLast = cFirst then
        "Yes"
    else
        "No"

printfn "%s" (run "rng" "gorilla" "apple")
//=> Yes

printfn "%s" (run "yakiniku" "unagi" "sushi")
//=> No

printfn "%s" (run "a" "a" "a")
//=> Yes

printfn "%s" (run "aaaaaaaaab" "aaaaaaaaaa" "aaaaaaaaab")
//=> No

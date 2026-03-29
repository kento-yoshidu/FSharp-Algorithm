// https://atcoder.jp/contests/abc218/tasks/abc218_a

let fn n (s: string) =
    if s.[n - 1] = 'o' then
        "Yes"
    else
        "No"

printfn "%s" (fn 4 "oooxoox")
//=> Yes

printfn "%s" (fn 7 "ooooooo")
//=> No

// https://atcoder.jp/contests/abc409/tasks/abc409_a

let fn _n t a =
    Seq.zip t a
    |> Seq.exists (fun (x, y) -> x = 'o' && y = 'o')
    |> fun exists -> if exists then "Yes" else "No"


printfn "%s" (fn 4 "oxoo" "xoox")
//=> Yes

printfn "%s" (fn 5 "xxxxx" "ooooo")
//=> No

printfn "%s" (fn 10 "xoooxoxxxo" "ooxooooxoo")
//=> Yes

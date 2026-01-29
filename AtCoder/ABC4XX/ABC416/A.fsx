// https://atcoder.jp/contests/abc416/tasks/abc416_a

let fn _n l r (s: string) =
    if s.[l-1..r-1] |> Seq.forall ((=) 'o') then
        "Yes"
    else
        "No"

printfn "%s" (fn 10 6 8 "xoxxooooxo")
//=> Yes

printfn "%s" (fn 9 6 8 "xoxxoxoox")
//=> No

// https://atcoder.jp/contests/abc019/tasks/abc019_1

let run a b c =
    [a; b; c]
    |> List.sort
    |> fun list -> list.[1]

printfn "%i" (run 2 3 4)
//=> 3

printfn "%i" (run 5 100 5)
//=> 5

printfn "%i" (run 3 3 3)
//=> 3

printfn "%i" (run 3 3 4)
//=> 3

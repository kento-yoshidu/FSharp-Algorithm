// https://atcoder.jp/contests/abc382/tasks/abc382_a

let fn _n d s =
    s
    |> Seq.sumBy (fun c -> if c = '.' then 1 else 0)
    |> (+) d

printfn "%i" (fn 5 2 ".@@.@")
//=> 4

printfn "%i" (fn 3 3 "@@@")
//=> 3

printfn "%i" (fn 10 4 "@@@.@@.@@.")
//=> 7

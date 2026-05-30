// https://atcoder.jp/contests/abc442/tasks/abc442_a

let fn s =
    s
    |> Seq.filter (fun c -> c = 'i' || c = 'j')
    |> Seq.length

printfn "%i" (fn "aiiaj")
//=> 3

printfn "%i" (fn "abcedfgh")
//=> 0

printfn "%i" (fn "jjjjjj")
//=> 6

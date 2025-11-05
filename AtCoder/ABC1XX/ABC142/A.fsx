// https://atcoder.jp/contests/abc142/tasks/abc142_a

let fn n =
    let count =
        [1..n]
        |> List.filter(fun x -> x % 2 <> 0)
        |> List.length

    float count / float n

printfn "%f" (fn 4)
//=> 0.500000

printfn "%f" (fn 5)
//=> 0.6000000000

printfn "%f" (fn 1)
//=> 1.000000

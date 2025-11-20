// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_g

let fn n x y =
    [1..n]
    |> List.filter(fun num -> num % x = 0 || num % y = 0)
    |> List.length

printfn "%i" (fn 15 3 5)
//=> 7

printfn "%i" (fn 1000000 11 13)
//=> 160839

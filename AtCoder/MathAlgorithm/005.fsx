// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_e

let fn n a =
    (a |> List.sum) % 100

printfn "%i" (fn 3 [30; 50; 70])
//=> 50

printfn "%i" (fn 10 [1; 2; 3; 4; 5; 6; 7; 8; 9; 10])
//=> 55

printfn "%i" (fn 5 [60; 60; 60; 60; 60])
//=> 0

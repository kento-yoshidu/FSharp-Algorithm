// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_c

let fn n a =
    a |> List.sum

printfn "%i" (fn 5 [3; 1; 4; 1; 5])
//=> 14

printfn "%i" (fn 3 [10; 20; 50])
//=> 80

printfn "%i" (fn 10 [1; 2; 3; 4; 5; 6; 7; 8; 9; 10])
//=> 55

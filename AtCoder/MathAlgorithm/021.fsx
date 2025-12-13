// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_u

let rec f n =
    if n <= 1 then
        1
    else
        n * f (n-1)

let fn n r =
    f n / (f r * f (n-r))

printfn "%i" (fn 6 2)
//=> 15

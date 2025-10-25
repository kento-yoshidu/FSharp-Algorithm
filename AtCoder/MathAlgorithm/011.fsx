// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_k

let isPrime n =
    let x = int (sqrt (float n))

    [2 .. x]
    |> List.forall (fun x -> n % x <> 0)

let fn n =
    [2 .. n]
    |> List.filter isPrime

printfn "%A" (fn 10)
//=> [2; 3; 5; 7]

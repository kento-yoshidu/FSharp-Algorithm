// https://atcoder.jp/contests/abc470/tasks/abc470_a

let fn n =
    [| 1..n |]
    |> Array.map (fun i -> if i % 3 = 0 then "Fizz" else string i)

printfn "%A" (fn 4)
//=> [| "1"; "2"; "Fizz"; "4" |]

printfn "%A" (fn 10)
//=> [|"1"; "2"; "Fizz"; "4"; "5"; "Fizz"; "7"; "8"; "Fizz"; "10"|]

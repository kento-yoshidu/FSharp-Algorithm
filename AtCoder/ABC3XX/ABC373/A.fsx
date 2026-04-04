// https://atcoder.jp/contests/abc373/tasks/abc373_a

let fn s =
    s
    |> Array.indexed
    |> Array.filter (fun (i, s) -> i + 1 = String.length s)
    |> Array.length

printfn "%i" (fn [| "january"; "february"; "march"; "april"; "may"; "june"; "july"; "august"; "september"; "october"; "november"; "december" |])
//=> 1

printfn "%i" (fn [| "ve"; "inrtfa"; "npccxva"; "djiq"; "lmbkktngaovl"; "mlfiv"; "fmbvcmuxuwggfq"; "qgmtwxmb"; "jii"; "ts"; "bfxrvs"; "eqvy" |])
//=> 2

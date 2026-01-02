// https://atcoder.jp/contests/abc402/tasks/abc402_a

let fn s =
    s
    |> String.filter (fun c -> System.Char.IsUpper c)

printfn "%s" (fn "AtCoderBeginnerContest")
//=> ACBC

printfn "%s" (fn "PaymentRequired")
//=> PR

printfn "%s" (fn "program")
//=>

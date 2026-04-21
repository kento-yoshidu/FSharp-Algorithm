// https://atcoder.jp/contests/abc187/tasks/abc187_a

let fn a b =
    let x = a / 100 + a / 10 % 10 + a % 10
    let y = b / 100 + b / 10 % 10 + b % 10

    max x y

printfn "%i" (fn 123 234)
//=> 9

printfn "%i" (fn 593 953)
//=> 17

printfn "%i" (fn 100 999)
//=> 27

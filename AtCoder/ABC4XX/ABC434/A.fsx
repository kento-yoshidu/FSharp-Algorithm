// https://atcoder.jp/contests/abc434/tasks/abc434_a

let fn w b =
    w * 1000 / b + 1

printfn "%i" (fn 80 5)
//=> 16001

printfn "%i" (fn 70 6)
//=> 11667

printfn "%i" (fn 100 100)
//=> 1001

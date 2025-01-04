// https://atcoder.jp/contests/abc043/tasks/abc043_a

let rec func n =
    if n = 1 then
        1
    else
        func(n-1) + n

let run n =
    func(n)

printfn "%i" (run 3)
//=> 6

printfn "%i" (run 10)
//=> 55

printfn "%i" (run 1)
//=> 1

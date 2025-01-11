// https://atcoder.jp/contests/abc032/tasks/abc032_a

let rec run a b n =
    if n % a = 0 && n % b = 0 then
        n
    else
        run a b (n+1)

printfn "%i" (run 2 3 8)
//=> 12

printfn "%i" (run 2 2 2)
//=> 2

printfn "%i" (run 12 8 25)
//=> 48

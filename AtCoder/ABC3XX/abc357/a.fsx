// https://atcoder.jp/contests/abc357/tasks/abc357_a

let rec calc n i rest (h: int[]) =
    if i = n then
        i
    elif rest < h.[i] then
        i
    else
        calc n (i+1) (rest - h.[i]) h

let fn n m (h: int[]) =
    calc n 0 m h

printfn "%i" (fn 5 10 [| 2; 3; 2; 5; 3 |])
//=> 3

printfn "%i" (fn 5 10 [| 2; 3; 2; 3; 5 |])
//=> 4

printfn "%i" (fn 1 5 [| 1 |])
//=> 1

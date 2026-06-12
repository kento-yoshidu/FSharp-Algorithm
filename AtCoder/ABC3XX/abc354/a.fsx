// https://atcoder.jp/contests/abc354/tasks/abc354_a

let rec calc h cur count =
    if cur > h then
        count
    else
        calc h (cur + pown 2 count) (count+1)

let fn h =
    calc h 0 0

printfn "%i" (fn 54)
//=> 6

printfn "%i" (fn 7)
//=> 4

printfn "%i" (fn 262144)
//=> 19

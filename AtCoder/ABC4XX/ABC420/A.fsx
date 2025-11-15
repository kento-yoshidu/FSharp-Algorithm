// https://atcoder.jp/contests/abc420/tasks/abc420_a

let fn x y =
    let m = (x + y) % 12

    if m <> 0 then
        m
    else
        12

printfn "%i" (fn 5 9)
//=> 2

printfn "%i" (fn 1 1)
//=> 2

printfn "%i" (fn 12 12)

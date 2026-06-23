// https://atcoder.jp/contests/abc246/tasks/abc246_a

let fn x1 y1 x2 y2 x3 y3 =
    x1 ^^^ x2 ^^^ x3, y1 ^^^ y2 ^^^ y3

printfn "%A" (fn -1 -1 -1 2 3 2)
//=> 3 -1

printfn "%A" (fn -60 -40 -60 -80 -20 -80)
//=> -20 -40

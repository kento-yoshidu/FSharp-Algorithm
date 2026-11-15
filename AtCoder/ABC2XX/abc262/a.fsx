// https://atcoder.jp/contests/abc262/tasks/abc262_a

let fn y =
    if y % 4 = 0 then
        y + 2
    elif y % 4 = 1 then
        y + 1
    elif y % 4 = 2 then
        y
    else
        y + 3

printfn "%i" (fn 2022)
//=> 2022

printfn "%i" (fn 2023)
//=> 2026

printfn "%i" (fn 3000)
//=> 3002
